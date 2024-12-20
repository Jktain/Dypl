using System;
using System.Windows.Forms;

namespace Dypl
{
    internal static class Program
    {
        //[STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Вікно_1());
        }
    }
}
