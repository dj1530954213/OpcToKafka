
namespace WJG_DataUpDate
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_OPCread = new Sunny.UI.UISymbolButton();
            this.Btn_OPCdisConnect = new Sunny.UI.UISymbolButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Btn_OPCconnect = new Sunny.UI.UISymbolButton();
            this.Btn_PushStart = new Sunny.UI.UISymbolButton();
            this.Btn_PushStop = new Sunny.UI.UISymbolButton();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.重启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.uiContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_OPCread
            // 
            this.Btn_OPCread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_OPCread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_OPCread.FillColor = System.Drawing.Color.Gray;
            this.Btn_OPCread.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.Btn_OPCread.FillColorGradient = true;
            this.Btn_OPCread.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OPCread.Location = new System.Drawing.Point(705, 3);
            this.Btn_OPCread.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_OPCread.Name = "Btn_OPCread";
            this.Btn_OPCread.Radius = 30;
            this.Btn_OPCread.Size = new System.Drawing.Size(228, 61);
            this.Btn_OPCread.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_OPCread.Symbol = 61888;
            this.Btn_OPCread.TabIndex = 0;
            this.Btn_OPCread.Text = "OPC数据加载及采集";
            this.Btn_OPCread.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OPCread.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_OPCread.Click += new System.EventHandler(this.Btn_OPCstart_Click);
            // 
            // Btn_OPCdisConnect
            // 
            this.Btn_OPCdisConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_OPCdisConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_OPCdisConnect.FillColor = System.Drawing.Color.Gray;
            this.Btn_OPCdisConnect.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.Btn_OPCdisConnect.FillColorGradient = true;
            this.Btn_OPCdisConnect.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OPCdisConnect.Location = new System.Drawing.Point(471, 3);
            this.Btn_OPCdisConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_OPCdisConnect.Name = "Btn_OPCdisConnect";
            this.Btn_OPCdisConnect.Radius = 30;
            this.Btn_OPCdisConnect.Size = new System.Drawing.Size(228, 61);
            this.Btn_OPCdisConnect.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_OPCdisConnect.Symbol = 61534;
            this.Btn_OPCdisConnect.TabIndex = 0;
            this.Btn_OPCdisConnect.Text = "断开OPC服务器";
            this.Btn_OPCdisConnect.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OPCdisConnect.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_OPCdisConnect.Click += new System.EventHandler(this.Btn_OPCstop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1648, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "OPC连接状态";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(124, 21);
            this.toolStripStatusLabel1.Text = "OPC连接状态：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(122, 21);
            this.toolStripStatusLabel2.Text = "推送服务状态：";
            // 
            // Btn_OPCconnect
            // 
            this.Btn_OPCconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_OPCconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_OPCconnect.FillColor = System.Drawing.Color.Gray;
            this.Btn_OPCconnect.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.Btn_OPCconnect.FillColorGradient = true;
            this.Btn_OPCconnect.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OPCconnect.Location = new System.Drawing.Point(237, 3);
            this.Btn_OPCconnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_OPCconnect.Name = "Btn_OPCconnect";
            this.Btn_OPCconnect.Radius = 30;
            this.Btn_OPCconnect.Size = new System.Drawing.Size(228, 61);
            this.Btn_OPCconnect.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_OPCconnect.Symbol = 61926;
            this.Btn_OPCconnect.TabIndex = 0;
            this.Btn_OPCconnect.Text = "连接OPC服务器";
            this.Btn_OPCconnect.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OPCconnect.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_OPCconnect.Click += new System.EventHandler(this.Btn_OPCconnect_Click);
            // 
            // Btn_PushStart
            // 
            this.Btn_PushStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PushStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_PushStart.FillColor = System.Drawing.Color.Gray;
            this.Btn_PushStart.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.Btn_PushStart.FillColorGradient = true;
            this.Btn_PushStart.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_PushStart.Location = new System.Drawing.Point(939, 3);
            this.Btn_PushStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_PushStart.Name = "Btn_PushStart";
            this.Btn_PushStart.Radius = 30;
            this.Btn_PushStart.Size = new System.Drawing.Size(228, 61);
            this.Btn_PushStart.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_PushStart.Symbol = 363231;
            this.Btn_PushStart.TabIndex = 0;
            this.Btn_PushStart.Text = "数据推送开启";
            this.Btn_PushStart.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_PushStart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_PushStart.Click += new System.EventHandler(this.Btn_PushStart_Click);
            // 
            // Btn_PushStop
            // 
            this.Btn_PushStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PushStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_PushStop.FillColor = System.Drawing.Color.Gray;
            this.Btn_PushStop.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.Btn_PushStop.FillColorGradient = true;
            this.Btn_PushStop.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_PushStop.Location = new System.Drawing.Point(1173, 3);
            this.Btn_PushStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_PushStop.Name = "Btn_PushStop";
            this.Btn_PushStop.Radius = 30;
            this.Btn_PushStop.Size = new System.Drawing.Size(228, 61);
            this.Btn_PushStop.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_PushStop.Symbol = 61453;
            this.Btn_PushStop.TabIndex = 0;
            this.Btn_PushStop.Text = "数据推送停止";
            this.Btn_PushStop.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_PushStop.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_PushStop.Click += new System.EventHandler(this.Btn_PushStop_Click);
            // 
            // uiRichTextBox1
            // 
            this.uiRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiRichTextBox1.FillColor = System.Drawing.Color.Azure;
            this.uiRichTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRichTextBox1.Location = new System.Drawing.Point(4, 299);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox1.ShowText = false;
            this.uiRichTextBox1.Size = new System.Drawing.Size(1640, 435);
            this.uiRichTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiRichTextBox1.TabIndex = 3;
            this.uiRichTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiRichTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.BackColor = System.Drawing.Color.LightGray;
            this.uiMarkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiMarkLabel1.Font = new System.Drawing.Font("华文琥珀", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(3, 0);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.Black;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(1642, 221);
            this.uiMarkLabel1.TabIndex = 4;
            this.uiMarkLabel1.Text = "工控数据采集服务";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uiRichTextBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uiMarkLabel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1648, 739);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28449F));
            this.tableLayoutPanel3.Controls.Add(this.Btn_PushStop, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_OPCconnect, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_PushStart, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_OPCdisConnect, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_OPCread, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 6, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 224);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1642, 67);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBox1.FillColor = System.Drawing.Color.AliceBlue;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(3, 34);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 13);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Radius = 20;
            this.uiTextBox1.ScrollBarBackColor = System.Drawing.Color.MediumAquamarine;
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(222, 23);
            this.uiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox1.TabIndex = 2;
            this.uiTextBox1.Text = "WJGXF-OPT1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox1.Watermark = "";
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.uiTextBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.uiSymbolLabel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(228, 61);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(3, 3);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(222, 24);
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.TabIndex = 3;
            this.uiSymbolLabel1.Text = "OPC服务器计算机名";
            this.uiSymbolLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.uiTextBox2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.uiSymbolLabel2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1407, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(232, 61);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBox2.FillColor = System.Drawing.Color.AliceBlue;
            this.uiTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox2.Location = new System.Drawing.Point(3, 34);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 13);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Radius = 20;
            this.uiTextBox2.ScrollBarBackColor = System.Drawing.Color.MediumAquamarine;
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(226, 23);
            this.uiTextBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox2.TabIndex = 2;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox2.Watermark = "";
            this.uiTextBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(3, 3);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(226, 24);
            this.uiSymbolLabel2.Symbol = 62144;
            this.uiSymbolLabel2.TabIndex = 3;
            this.uiSymbolLabel2.Text = "累计运行时间";
            this.uiSymbolLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重启ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.uiContextMenuStrip1.ShowImageMargin = false;
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(88, 56);
            this.uiContextMenuStrip1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // 重启ToolStripMenuItem
            // 
            this.重启ToolStripMenuItem.Name = "重启ToolStripMenuItem";
            this.重启ToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.重启ToolStripMenuItem.Text = "重启";
            this.重启ToolStripMenuItem.Click += new System.EventHandler(this.重启ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.uiContextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1648, 765);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.uiContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UISymbolButton Btn_OPCread;
        private Sunny.UI.UISymbolButton Btn_OPCdisConnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Sunny.UI.UISymbolButton Btn_OPCconnect;
        private Sunny.UI.UISymbolButton Btn_PushStart;
        private Sunny.UI.UISymbolButton Btn_PushStop;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 重启ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

