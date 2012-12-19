using System;
using System.Globalization;
using System.Windows.Forms;
using MSCD.Model;

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
            var loginForm = new DlgLoginForm();
            var loginResult = loginForm.ShowDialog();
            if(!loginForm.IsDisposed)
            {
                if (loginResult == DialogResult.OK)
                {
                    Application.Run(new MainForm(loginForm.Workspace, loginForm.User));
                }
            }
        }
    }
}
