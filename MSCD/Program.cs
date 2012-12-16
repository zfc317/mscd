using System;
using System.Globalization;
using System.Windows.Forms;

namespace MSCD.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("zh-CN");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(){Visible=false});
        }
    }
}
