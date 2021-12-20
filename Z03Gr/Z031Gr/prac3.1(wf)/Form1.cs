using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac3._1_wf_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        double ab, ac, cd;
        double Main()
        {
            return ab + ac + cd + f(f(ab, ac), cd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            In();
            label5.Text = Main().ToString();
        }

        void In()
        {
            if (Double.TryParse(textBox1.Text, out ab) &&
                Double.TryParse(textBox2.Text, out ac) &&
                Double.TryParse(textBox3.Text, out cd))
            { }
            else
            {
                MessageBox.Show("Вы ввели что-то не то, попробуйте ещё раз");
            }

        }
        double f(double a, double b)
        {
            double c = Math.Sqrt(a * a + b * b);
            return c;
        }
    }
}
