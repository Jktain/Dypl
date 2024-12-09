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
            Вікно_1 Fir_win = new Вікно_1();
            Application.Run(Fir_win);
        }
    }
}
