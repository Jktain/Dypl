﻿using System;
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
        public Вікно_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Вікно_2 Sec_win = new Вікно_2();
            Sec_win.Show();
            Close();
        }
    }
}
