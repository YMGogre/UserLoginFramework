using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginFramework
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginPage loginPage = new LoginPage();
            if(loginPage.ShowDialog() == DialogResult.OK)
            {
                loginPage.Close();
                Application.Run(new MainForm(loginPage.Uname));
            }
        }
    }
}
