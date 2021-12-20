using System;
using System.Text;
using System.Windows.Forms;

namespace Z063
{
    public partial class Form1 : Form
    {
        int n;
        int[,] arr;
        Random r = new Random();
        StringBuilder txt = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }
        void Main()
        {
            if (Int32.TryParse(textBox2.Text, out n) && n>0)
            {
                txt.Clear();richTextBox1.Clear();
                arr = new int[n,n];
                for (int i = 0; i < n; i++)
                {
                    txt.Append("\n\n");
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = r.Next(-10, 10);
                        txt.Append($"{arr[i, j]}  ");
                    }
                }
                richTextBox1.AppendText(txt.ToString());
            }
            else
            {
                MessageBox.Show("Размер матрицы должен определяться положительным целочисленным значением");
            }
                
        }
        void postMain()
        {
            txt.Clear(); richTextBox1.Clear();
            for (int i = 0; i < n; i++)
            {
                txt.Append("\n\n");
                if ((i+1) % 2 == 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        txt.Append($"{arr[i, j]}  ");
                    }
                }
                else
                {
                    for (int j = n-1; j >= 0; j--)
                    {
                        txt.Append($"{arr[i, j]}  ");
                    }
                }
            }
            richTextBox1.Text = txt.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            postMain();
        }
    }
}
