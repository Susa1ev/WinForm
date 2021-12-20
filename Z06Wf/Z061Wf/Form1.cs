using System;
using System.Text;
using System.Windows.Forms;

namespace Z061Wf
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int n;
        int[] arr;
        int[,] secarr;
        public Form1()
        {
            InitializeComponent();
        }
        void Main()
        {
            richTextBox1.Clear();richTextBox2.Clear();
            if (Int32.TryParse(textBox1.Text, out n) && n>0)
            {
                arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rnd.Next(-10, 10);
                    richTextBox1.AppendText(arr[i].ToString()); richTextBox1.AppendText(" ");
                    if(arr[i]%2==1||arr[i]%2 == -1)
                    {
                        richTextBox2.AppendText((i+1).ToString()); richTextBox2.AppendText(" ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Размерность массива должна быть положительным целым числом");
            }
        }
        void secMain()
        {
            richTextBox3.Clear();richTextBox4.Clear();
            secarr = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i] = rnd.Next(-10, 10);
                    richTextBox4.AppendText(arr[i].ToString()); richTextBox4.AppendText(" ");
                    if (arr[i] % 2 == 1 || arr[i] % 2 == -1)
                    {
                        richTextBox3.AppendText((i + 1).ToString()); richTextBox3.AppendText((j + 1).ToString()); richTextBox3.AppendText(" ");
                    }
                }
                richTextBox4.AppendText("\n");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main();
            secMain();
        }
    }
}
