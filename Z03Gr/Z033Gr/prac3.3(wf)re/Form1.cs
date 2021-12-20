using System;
using System.Windows.Forms;

namespace prac3._3_wf_re
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b, h;
        double y;
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
        static void f(double x, out double y)
        {
            if (x == 1 || x == -1)
            {
                y = 1;
            }
            else if (x >= 0 && x != 1)
            {
                y = -1 / (1 - x);
            }
            else
            {
                y = 1 / (1 + x);
            }
        }
        void Main()
        {
            if (Int32.TryParse(textBox1.Text, out a) &&
                Int32.TryParse(textBox2.Text, out b) &&
                Int32.TryParse(textBox3.Text, out h))
            {
                label4.Text = string.Empty;
                label4.Text += "Через static void f(double x, out double y)";
                for (int i = a; i < b + 1; i += h)
                {
                    f(i, out y);
                    label4.Text += i + "-" + y + "\n";
                }
                label4.Text += "\nЧерез double f(double x)";
                for (int i = a; i < b + 1; i += h)
                {
                    label4.Text += i + "-" + f(i) + "\n";
                }
            }
            else
            {
                MessageBox.Show("Вы ввели что-то не то");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }

    }
}
