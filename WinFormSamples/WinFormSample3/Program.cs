using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// C# ile girilen bir cümle ya da metnin içindeki kelimeleri ayýrma ve ayrýlan bu kelimelerin cümle içinde kaç kere tekrarlandýðýný bulma iþlemi

namespace WinFormSample3
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }



    }
}
