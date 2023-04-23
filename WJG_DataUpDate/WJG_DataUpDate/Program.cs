using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WJG_DataUpDate
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process instance = RunningInstance();
            if (instance == null)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                HandleRunningInstance(instance);
                MessageBox.Show("当前程序已经运行", "系统提示");
            }
        }
        const int WS_SHOWNORMAL = 3;
        public static Process RunningInstance()
        {
            Process currentProcess = Process.GetCurrentProcess();//获取当前程序的进程实例
            Process[] processByName = Process.GetProcessesByName(currentProcess.ProcessName);//通过当前的进程实例的名称找到与其相关的所有进程
            foreach (Process TheProcess in processByName)
            {
                /*GetEntryAssembly获取当前程序第一个启动的程序  一般是xxx.exe
                 *GetExecutingAssembly获取的是当前执行的方法所在的程序文件   可能是.exe也可能是当前方法所在的dll文件
                 *具体解释参考   https://www.cnblogs.com/wholeworld/p/7941216.html
                 */
                if ((TheProcess.Id != currentProcess.Id) && (Assembly.GetEntryAssembly().Location.Replace("/", @"\") == currentProcess.MainModule.FileName))
                {
                    return TheProcess;
                }
                /*在本if语句中如果现正在执行的所有与应用相关的进程中出现了另一个进程且都在同一个程序集中则返回这个进程的信息
                 其实当我们在原程序已经运行的情况下再次启动程序系统会为其新分配一个进程号，所以在我们的if判断内我们需要找到同一个名字的程序在同样的程序集中是否有两个不同的进程ID
                如果有则说明程序已经在运行了
                 */

            }
            return null;
        }
        public static void HandleRunningInstance(Process instance)
        {

            ShowWindowAsync(instance.MainWindowHandle, 3);//最大化窗体
            SetForegroundWindow(instance.MainWindowHandle);
        }
        [DllImport("User32.dll")]
        static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);
    }
}
