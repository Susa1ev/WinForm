using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac5._1wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, h;

        private void button1_Click(object sender, EventArgs e)
        {
            In();
        }

        double f(double x)
        {
            try
            {
                if (x == -0.2 || x == 2) throw new Exception();
                else return Math.Log(x - 2) / Math.Sqrt(5 * x - 1);
            }
            catch
            {
                throw;
            }
        }
        void In()
        {
            if (Double.TryParse(textBox1.Text, out a) &&
                Double.TryParse(textBox2.Text, out b) &&
                Double.TryParse(textBox3.Text, out h))
            {
                label4.Text = string.Empty;
                for (double i = a; i < b; i += h)
                {
                    try
                    {
                        if (i <= 2)
                        {
                            throw new Exception();
                        }
                        label4.Text+=$"\ny({i}) = {f(i):f4}";
                    }
                    catch
                    {
                        label4.Text += $"\ny({i}) = не определена";
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы ввели что-то не то");
            }
        }
    }
}
