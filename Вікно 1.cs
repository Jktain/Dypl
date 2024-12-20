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
    public partial class Вікно_1 : Form
    {
        public Вікно_1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Вікно_2 nextForm = Application.OpenForms.OfType<Вікно_2>().FirstOrDefault();

            if (nextForm != null)
            {
                nextForm.Show();
            }
            else
            {
                Вікно_2 NextForm = new Вікно_2();
                NextForm.Show();
            }

            Hide();
        }

    }
}
