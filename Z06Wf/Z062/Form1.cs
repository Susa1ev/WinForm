using System;
using System.Windows.Forms;

namespace Z062
{
    public partial class Form1 : Form
    {
        int k;
        double[] arr;
        double y = 0;
        Random r = new Random();
        bool flag;
        void Viv()
        {
            label4.Text = string.Empty;
            if(flag)
            {
                label4.Text = y.ToString();
            }
            else
            {
                label4.Text = "Не найдено";
            }
        }
        void Zapoln()
        {
            label2.Text = string.Empty; 
            y = Int32.MinValue;
            if (Int32.TryParse(textBox1.Text, out k)&& k>0)
            {
                arr = new double[k];
                for(int i = 0; i < k; i++)
                {
                    arr[i] = r.Next(-10,9)+r.NextDouble();
                    label2.Text += arr[i] + " ";
                    if(arr[i] > y && arr[i] < 0){y = arr[i]; flag = true; }
                }
            }
            else
            {
                MessageBox.Show("Размерность массива должна быть положительным целочисленным значением");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zapoln();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Viv();
        }
    }
}
