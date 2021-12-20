using System;
using System.Text;
using System.Windows.Forms;

namespace Z064
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int n, k1, k2;
        int[][] arr;
        int[] bufArr;
        StringBuilder lbl2 = new StringBuilder(), lbl6 = new StringBuilder();
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }
        void Main()
        {
            if (Int32.TryParse(textBox2.Text, out n) &&
                Int32.TryParse(textBox1.Text, out k1) &&
                Int32.TryParse(textBox3.Text, out k2)&& n>0)
            {
                if (k1 >= 1&& k2 >k1)
                {
                    flag = true;
                    arr = new int[n][];
                    bufArr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = new int[n];
                        bufArr[i] = 0;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            arr[i][j] = r.Next(-10, 10);
                            lbl2.Append($"{arr[i][j]} ");
                        }
                        lbl2.Append("\n");
                    }
                    richTextBox1.Text = lbl2.ToString();

                }
                else
                {
                    MessageBox.Show("К1 должна быть равна 1 или более, К2 должна быть больше К1");
                }
            }
            else
            {
                MessageBox.Show("Все данные должны иметь положительное целочисленное значение");
            }
        }
        void postMain()
        {
            if(flag)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = k1-1; j <= k2-1; j++)
                    {
                        bufArr[i] += arr[i][j];
                    }
                    lbl6.Append($"{bufArr[i]}\n");
                }
                richTextBox2.Text = lbl6.ToString();
            }
            else
            {
                lbl6.Append("Неизвестное значение");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lbl2.Clear();
            Main();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lbl6.Clear();
            postMain();
        }
    }
}
