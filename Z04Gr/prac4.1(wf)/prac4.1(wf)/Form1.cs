using System;
using System.Windows.Forms;

namespace prac4._1_wf_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        int nod(int a, int b)
        {
            if (a == b) { return a; }
            else if (a > b)
            {
                return nod(a - b, b);
            }
            else
            {
                return nod(a, b - a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }

        void Main()
        {
            label5.Text = string.Empty;
            if( Int32.TryParse(textBox1.Text, out a)&&
                Int32.TryParse(textBox2.Text, out b))
            {
                label5.Text = nod(Math.Abs(a), Math.Abs(b)).ToString();
            }
            else
            {
                MessageBox.Show("Вы ввели что-то не то");
            }
        }
    }
}
