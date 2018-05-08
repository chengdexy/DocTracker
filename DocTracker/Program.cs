using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocTracker
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //#region 这段代码将ef生成的mdf文件固定为一份, 存储在app_data文件夹中, 避免分歧
            //string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            //if (dataDir.EndsWith(@"\bin\Debug\")
            //|| dataDir.EndsWith(@"\bin\Release\"))
            //{
            //    dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName + "\\App_Data";
            //    AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            //}
            //#endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
