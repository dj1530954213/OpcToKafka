using Confluent.Kafka;
using Newtonsoft.Json;
using OPCAutomation;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WJG_DataUpDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.BeginDate = DateTime.Now;
            this.LastDate = DateTime.Now;
            InitializeComponent();
        }
        private DateTime BeginDate;
        private DateTime LastDate;
        public Sunny.UI.UIPage messageBox = new UIPage();
        //kafka相关设置
        ProducerConfig kafka = new ProducerConfig();
        OPCServer server;
        OPCGroups groups;
        //OPCGroup group;
        OPCGroup[] groupList;
        List<Point> pointList = new List<Point>();
        string remoteName;
        Dictionary<int, Point> pointDictionary = new Dictionary<int, Point>();
        Dictionary<string, List<string>> itemNameDictionary = new Dictionary<string, List<string>>();
        Dictionary<string, List<int>> clientHandleDictionary = new Dictionary<string, List<int>>();
        ManualResetEvent LoopResetEvent = new ManualResetEvent(false);
        string OpcServerName = "Kepware.KEPServerEX.V6";
        List<string> groupName = new List<string>();
        List<int> scanRate = new List<int>();
        JsonResult jsonResult = new JsonResult();
        Array[] serverHandles, errors;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            InitCsv();
            messageBox.ShowSuccessTip("初始化成功", 3000);
        }
        private void InitCsv()
        {
            using (StreamReader groupConfigRead = new StreamReader($"{Directory.GetCurrentDirectory()}\\InitConfigWJG.csv", Encoding.Default))
            {
                //获取OPCserver名称
                OpcServerName = groupConfigRead.ReadLine().Split(',')[1];
                //将所有组名添加至列表中
                groupName.AddRange(groupConfigRead.ReadLine().Split(',')[1].Split('-'));
                //按照实际组的个数实例化组列表
                groupList = new OPCGroup[groupName.Count];
                //实例化各组内item对应服务端的处理句柄队列，以及错误队列
                serverHandles = new Array[groupName.Count];
                errors = new Array[groupName.Count];
                //将所有采集速率转换为int添加至列表中
                string[] scanRateMind = groupConfigRead.ReadLine().Split(',')[1].Split('-');
                int[] scanRateResult = new int[scanRateMind.Length];
                for (int i = 0; i < scanRateMind.Length; i++)
                {
                    scanRateResult[i] = Convert.ToInt32(scanRateMind[i]);
                }
                scanRate.AddRange(scanRateResult);
                groupConfigRead.ReadLine();//跳过标题行
                while (true)
                {
                    string str = groupConfigRead.ReadLine();
                    if (str is null)//判断是否还有记录
                    {
                        break;
                    }
                    string[] result = str.Split(',');
                    if (itemNameDictionary.ContainsKey(result[0]))//根据组是否存在于组集合中，如果有就添加记录如果没有就新建再添加记录
                    {
                        itemNameDictionary[result[0]].Add(result[1]);
                        clientHandleDictionary[result[0]].Add(Convert.ToInt32(result[2]));
                    }
                    else
                    {
                        itemNameDictionary.Add(result[0], new List<string>());
                        clientHandleDictionary.Add(result[0], new List<int>());
                        itemNameDictionary[result[0]].Add(result[1]);
                        clientHandleDictionary[result[0]].Add(Convert.ToInt32(result[2]));
                    }
                    switch (result[3])//根据数据类型将记录添加至映射点位字典中
                    {
                        case "模拟量":
                            pointList.Add(new AnalogPoint(result[4]));
                            break;
                        case "状态量":
                            pointList.Add(new digitalPoint(result[4]));
                            break;
                        default:
                            break;
                    }
                }
                groupConfigRead.Close();
                groupConfigRead.Dispose();
            }
        }
        private void LoadConfig(string[] groupName, int[] upDateReat, Dictionary<string, List<string>> itemNames, Dictionary<string, List<int>> clientHandle)
        {
            for (int i = 0; i < groupName.Length; i++)
            {
                CreatGroup(groupName[i], i, upDateReat[i], itemNames[groupName[i]], clientHandle[groupName[i]]);
            }
            Btn_OPCread.Enabled = false;
        }
        private void CreatGroup(string thegroupName, int groupIndex, int upDataRate, List<string> itemName, List<int> clientHandle)
        {
            #region AAA
            //groups = server.OPCGroups;
            //groups.DefaultGroupDeadband = 0;//死区需要测试OPC SERVER是否具备设置死区的功能，如果没有设置死区的功能则无法接收datechange事件的回调
            //groups.DefaultGroupIsActive = true;
            //groups.DefaultGroupUpdateRate = upDataRate;//轮询时间正常
            //groupList[groupIndex] = groups.Add(thegroupName);
            //groupList[groupIndex].IsSubscribed = true;
            //int index = 0;
            //foreach (var item in itemName)
            //{
            //    groupList[groupIndex].OPCItems.AddItem(item, clientHandle[index]);
            //    //groupList[groupIndex].OPCItems.AddItems()
            //    index++;
            //}
            //groupList[groupIndex].DataChange += OPCGroup1_DataChange;//回调事件触发
            #endregion
            groups = server.OPCGroups;
            groups.DefaultGroupDeadband = 0;//死区需要测试OPC SERVER是否具备设置死区的功能，如果没有设置死区的功能则无法接收datechange事件的回调
            groups.DefaultGroupIsActive = true;
            groups.DefaultGroupUpdateRate = upDataRate;//轮询时间正常
            groupList[groupIndex] = groups.Add(thegroupName);

            groupList[groupIndex].IsSubscribed = true;
            //申明批量添加所需要的队列和列表
            List<string> itemNameList = new List<string>();
            itemNameList.Add("");
            itemNameList.AddRange(itemName);
            List<int> clientHandleList = new List<int>();
            clientHandleList.Add(0);
            clientHandleList.AddRange(clientHandle);
            Array itemNameArray = itemNameList.ToArray();
            Array clientHandleArray = clientHandleList.ToArray();
            //传入队列直接批量添加数组
            groupList[groupIndex].OPCItems.AddItems(itemName.Count, itemNameArray, clientHandleArray, out serverHandles[groupIndex], out errors[groupIndex]);

            groupList[groupIndex].DataChange += OPCGroup1_DataChange;//回调事件触发

        }

        /// <summary>
        /// 数值改变事件处理器
        /// </summary>
        /// <param name="TransactionID"></param>
        /// <param name="NumItems">数据发生改变的个数</param>
        /// <param name="ClientHandles">记录唯一标识</param>
        /// <param name="ItemValues">返回的值集合</param>
        /// <param name="Qualities">返回的通讯质量集合</param>
        /// <param name="TimeStamps">时间戳集合</param>
        private void OPCGroup1_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)//注意这里从1开始是因为在初始化组的时候就已经有一个最初的类了
            {
                pointList[(int)ClientHandles.GetValue(i) - 1].presentValue = ItemValues.GetValue(i); //根据OPC返回自带的clientHandle的值来在点位列表中进行索引，点对象的值
            }
        }
        private void Btn_OPCstart_Click(object sender, EventArgs e)
        {
            if (server.ServerState == (int)OPCServerState.OPCRunning)
            {
                try
                {
                    jsonResult.pointListResult = pointList;
                    LoadConfig(groupName.ToArray(), scanRate.ToArray(), itemNameDictionary, clientHandleDictionary);
                    messageBox.ShowSuccessTip("OPC数据采集服务启动成功", 3000);
                    uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------OPC数据采集服务开启成功\n");
                    PushLoop();
                }
                catch (Exception ex)
                {
                    messageBox.ShowErrorTip(ex.Message.ToString());
                    uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------OPC数据采集服务开启错误{ex.Message.ToString()}\n");
                }
            }
            else
            {
                uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------未连接OPC服务器请连接OPC服务器后再次操作\n");
            }
        }

        private void Btn_OPCstop_Click(object sender, EventArgs e)
        {
            if (server.ServerState == (int)OPCServerState.OPCDisconnected)
            {
                messageBox.ShowSuccessTip("OPC连接已关闭");
                toolStripStatusLabel1.Text = "OPC连接状态：断开连接";
                uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------OPC服务器断开成功\n");
            }
            else
            {
                try
                {
                    server.Disconnect();
                    messageBox.ShowSuccessTip("OPC连接已关闭");
                    toolStripStatusLabel1.Text = "OPC连接状态：断开连接";
                    uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------OPC服务器断开成功\n");
                }
                catch (Exception ex)
                {
                    messageBox.ShowErrorTip(ex.Message.ToString());
                    uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------OPC服务器断开错误：{ex.Message.ToString()}\n");
                }
            }

        }

        private void Btn_OPCconnect_Click(object sender, EventArgs e)
        {
            remoteName = uiTextBox1.Text;
            server = new OPCServer();
            try
            {
                //server.Connect(OpcServerName, Dns.GetHostName());
                server.Connect(OpcServerName, remoteName);
                if (server.ServerState == (int)OPCServerState.OPCRunning)
                {
                    messageBox.ShowSuccessTip("OPC连接成功");
                    toolStripStatusLabel1.Text = "OPC连接状态：连接成功";
                    uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------OPC服务器连接成功\n");
                }
                else
                {
                    messageBox.ShowErrorTip("OPC连接失败");
                    uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------OPC服务器连接失败\n");
                    return;
                }
            }
            catch (Exception ex)
            {
                messageBox.ShowErrorTip(ex.Message.ToString());
                uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------OPC服务器连接错误：{ex.Message.ToString()}\n");
                return;
            }
        }

        private void PushLoop()
        {
            //监控程序运行时间
            System.Diagnostics.Stopwatch stopwatch = new Stopwatch();
            //实例化kafka对象
            var bootstrapServers = new string[] { "192.168.1.101:9092" };
            var topic = "firstTopic";
            KafkaProducer producer = new KafkaProducer(bootstrapServers);
            int index = 0;
            Task.Run(() =>
            {
                while (true)
                {
                    stopwatch.Start();
                    LoopResetEvent.WaitOne();
                    //foreach (var item in pointList)
                    //{
                    //    Console.WriteLine($"name:{item.Name}    value:{item.presentValue} time{DateTime.Now.ToString()}");
                    //}
                    //Console.WriteLine("\n\n");
                    Console.WriteLine(JsonConvert.SerializeObject(jsonResult));
                    //producer.Publish(topic, 0, "Test", JsonConvert.SerializeObject(jsonResult));
                    try
                    {
                        producer.Publish(topic, 0, "Test", jsonResult);
                    }
                    catch (Exception ex)
                    {
                        uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------数据推送失败：{ex.Message.ToString()}\n");
                    }
                    Console.WriteLine("\n\n" + stopwatch.Elapsed);
                    Thread.Sleep(2000);
                }
            });

        }

        private void Btn_PushStop_Click(object sender, EventArgs e)
        {
            LoopResetEvent.Reset();
            uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------数据推送服务停止\n");
            toolStripStatusLabel2.Text = "推送服务状态：停止";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (base.WindowState == FormWindowState.Normal)
            {
                base.Hide();
                base.WindowState = FormWindowState.Minimized;
            }
            else
            {
                base.Visible = true;
                base.WindowState = FormWindowState.Normal;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LastDate = DateTime.Now;
            TimeSpan span = this.BeginDate.Subtract(this.LastDate);
            this.uiTextBox2.Text = "累计运行:" + span.Days.ToString().Replace("-", "") + "日" + span.Hours.ToString().Replace("-", "") + "时" + span.Minutes.ToString().Replace("-", "") + "分" + span.Seconds.ToString().Replace("-", "") + "秒";
        }

        private void 重启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Dispose();
            Process[] processByName = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
            Application.ExitThread();
            Application.Exit();
        }

        private void Btn_PushStart_Click(object sender, EventArgs e)
        {
            LoopResetEvent.Set();
            uiRichTextBox1.AppendText($"\n时间：{DateTime.Now.ToString()}--------------数据推送服务开启\n");
            toolStripStatusLabel2.Text = "推送服务状态：运行";
        }
    }
}
