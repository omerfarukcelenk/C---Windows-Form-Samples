using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// C# ile girilen bir c�mle ya da metnin i�indeki kelimeleri ay�rma ve ayr�lan bu kelimelerin c�mle i�inde ka� kere tekrarland���n� bulma i�lemi

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
