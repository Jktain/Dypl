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
            Вікно_1 previousForm = Application.OpenForms.OfType<Вікно_1>().FirstOrDefault();

            if (previousForm != null)
            {
                previousForm.Show();
            }

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Вікно_3 nextForm = Application.OpenForms.OfType<Вікно_3>().FirstOrDefault();

            if (nextForm != null)
            {
                nextForm.Show();
            }
            else
            {
                Вікно_3 NextForm = new Вікно_3();
                NextForm.Show();
            }

            Hide();
        }
    }
}
