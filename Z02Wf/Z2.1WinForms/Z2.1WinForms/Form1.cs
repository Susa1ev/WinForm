using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z2._1WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x = 0.0;
        double y = 0.0;
        public void sravnenie()
        {
            if (x < 0 && x > -23 && y < 0 && y > x)
            {
                label3.Text = "Находится внутри функций";
            }
            else if (x == 0 || x == -23 || y == 0)
            {
                label3.Text = "Находится на функциях";
            }
            else
            {
                label3.Text = "Находится вне функций";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out x)) { }
            else
            {
                MessageBox.Show("Вы ввели что-то не то в поле <X>");
            }
            if (Double.TryParse(textBox2.Text, out y)) { }
            else
            {
                MessageBox.Show("Вы ввели что-то не то в поле <Y>");
            }
            sravnenie();
        }
    }
}
