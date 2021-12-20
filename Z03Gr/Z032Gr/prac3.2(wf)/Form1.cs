using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac3._2_wf_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b, h;

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }

        double f(double x)
        {
            if (x == 1 || x == -1)
            {
                return 1;
            }
            else if (x >= 0 && x != 1)
            {
                return -1 / (1 - x);
            }
            else
            {
                return 1 / (1 + x);
            }
        }
        void Main()
        {
            if (Int32.TryParse(textBox1.Text, out a) &&
                Int32.TryParse(textBox2.Text, out b) &&
                Int32.TryParse(textBox3.Text, out h))
            {
                label4.Text = string.Empty;
                for (int i = a; i < b + 1; i += h)
                {
                    label4.Text += i + "-" + f(i) + "\n";
                }

            }
            else
            {
                MessageBox.Show("Вы ввели что-то не то, попробуйте ещё раз");
            }

        }
    }
}

