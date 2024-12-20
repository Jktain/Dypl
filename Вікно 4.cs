using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dypl
{
    public partial class Вікно_4 : Form
    {
        private int cbi1 = 0;
        private int cbi2 = 0;
        private int cbi3 = 0;
        private int cbi4 = 0;

        private string intens1; 
        private string intens2; 
        private string vir1; 
        private string vir2; 

        private Chart[] charts = new Chart[2];

        public Label[] labels = new Label[11];

        private void MakeGraph(string iName, string pName, double[] vir, double[] intens, Chart chart, bool need)
        {
            var series = new Series("Графік")
            {
                ChartType = SeriesChartType.Line,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                ChartArea = "ChartArea1"
            };

            for (int i = 0; i < vir.Length; i++)
            {
                series.Points.AddXY(vir[i], intens[i]);
            }

            chart.Series.Add(series);

            chart.ChartAreas[0].AxisX.Title = iName;
            chart.ChartAreas[0].AxisY.Title = pName;
        }

        private static int ExtractNumberFromName(string name)
        {
            string numberPart = new string(name.Where(char.IsDigit).ToArray());
            return int.TryParse(numberPart, out int number) ? number : 0; 
        }

        public Вікно_4()
        {
            InitializeComponent();
            charts = Controls
                .OfType<Chart>()
                .OrderBy(ch => ch.Name)
                .ToArray();         
                
            //MakeGraph(intens1, vir1, Calc.vir1, Calc.intens1, charts[0], true);
            //MakeGraph(intens1, vir2, Calc.vir2, Calc.intens1, charts[1], true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbi1 = comboBox1.SelectedIndex;
            intens1 = comboBox1.SelectedItem.ToString();

            for(int i = 0; i < intens1.Length; i++)
            {
                Calc.intens1[i] = Calc.p[cbi1] * (i + 1);
            }

            for (int i = 0; i < Calc.intens1.Length; i++)
            {

            }

            //MakeGraph(intens1, vir1, Calc.vir1, Calc.intens1, charts[0]);

            Calc.p[cbi1] = Calc.intens1[0];
        }

        private void Вікно_4_Load(object sender, EventArgs e)
        {
            labels = Controls
                .OfType<Label>()
                .OrderBy(lb => ExtractNumberFromName(lb.Name))
                .ToArray();

            labels[0].Text = "P0 = " + Calc.solve[0].ToString();
            labels[1].Text = "P_L = " + Calc.solve[9].ToString();
            labels[2].Text = "P_F = " + Calc.solve[10].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Вікно_3 previousForm = Application.OpenForms.OfType<Вікно_3>().FirstOrDefault();
            previousForm.Show();
            Close();
        }
    }
}
