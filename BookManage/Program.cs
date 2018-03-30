using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookManage
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new frmMain());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"\n程序退出!");
            }
        }
    }
}
