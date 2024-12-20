using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dypl
{
    public partial class Вікно_3 : Form
    {
        private TextBox[] teBo = new TextBox[23];

        private static int ExtractNumberFromName(string name)
        {
            string numberPart = new string(name.Where(char.IsDigit).ToArray());
            return int.TryParse(numberPart, out int number) ? number : 0; 
        }

        public void OpenForm()
        {
            
                Вікно_4 nextForm = new Вікно_4();
                nextForm.Show();
                Hide();
        }

        public bool Check()
        {
            for (int i = 0; i < teBo.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(teBo[i].Text) 
                    || !double.TryParse(teBo[i].Text, out double value)
                    || value <= 0)
                {
                    MessageBox.Show($"Усі поля повинні бути заповненні, а інтенсивності бути більші за нуль!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return false;
                }

                Calc.p[i] = value;
            }

            return true;
        }

        public Вікно_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Вікно_2 previousForm = Application.OpenForms.OfType<Вікно_2>().FirstOrDefault();
            previousForm.Show();
            Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                Calc.solve = Calc.SolveMatrixEquation(1, 1);
                OpenForm();
            }
        }

        private void Вікно_3_Load(object sender, EventArgs e)
        {
            teBo = Controls
                .OfType<TextBox>()
                .OrderBy(tb => ExtractNumberFromName(tb.Name)) 
                .ToArray();
        }
    }
}
