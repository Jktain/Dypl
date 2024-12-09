using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dypl
{
    public partial class Вікно_2 : Form
    {
        public Вікно_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Вікно_1 First_win = new Вікно_1();
            First_win.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Вікно_3 Third_win = new Вікно_3();
            Third_win.Show();
            Close();
        }
    }
}
