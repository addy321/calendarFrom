
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace PMRL
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
            Application.Run(new ZMRL());
            //System.Diagnostics.Process.Start("http://www.hellocsharp.com/code_list.aspx?type1_id=1");
        }
    }
}
