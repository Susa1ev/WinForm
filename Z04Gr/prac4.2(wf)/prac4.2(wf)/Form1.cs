using System;
using System.Windows.Forms;

namespace prac4._2_wf_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n, i = 0;
        void str(int i, string c)
        {
            int j = 0;
            while (j < i)
            {
                j++;
                label1.Text += c;
            }
        }
        void rec(int n, int i)
        {
            if (n >= 0)
            {
                str(i, "*");
                str(n, " ");
                str(i, "*");
                label1.Text += "\n";
                rec(n - 2, i + 1);
                str(i, "*");
                str(n, " ");
                str(i, "*");
                label1.Text += "\n";
            }
        }

        void Main()
        {
            if(Int32.TryParse(textBox1.Text, out n))
            {
                if(n%2==1)
                {
                    n++;
                }
                rec(n, i);
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
