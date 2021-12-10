using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Z09Wf
{
    public partial class Form1 : Form
    {
        bool flag = false;
        Random r = new Random();
        double[] dblArrIn;
        string[] strArrOut;
        double[] dblArrOut;
        double buf = Int32.MinValue;
        int n;
        StringBuilder sb = new StringBuilder();
        StringBuilder str = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }
        void schit()
        {
            if (Int32.TryParse(textBox1.Text, out n) && n > 0)
            {
                StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\text.txt", false);
                dblArrIn = new double[n];
                for (int i = 0; i < dblArrIn.Length; i++)
                {
                    dblArrIn[i] = r.Next(-10, 9) + r.NextDouble();
                    sb.Append(dblArrIn[i].ToString());
                    sb.Append(" ");
                }
                sw.WriteLine(sb.ToString());
                sw.Close();
                label4.Text = sb.ToString();
                sb.Clear();
                flag = true;
            }
            else
            {
                flag = false;
                MessageBox.Show("Размер последовательности чисел определяется целым положительным значением");
            }
        }
        void zap()
        {
            if (flag)
            {
                StreamReader sr = new StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\text.txt");
                str.Append(sr.ReadToEnd());
                strArrOut = str.ToString().Split(' ');
                dblArrOut = new double[strArrOut.Length];
                sr.Close();
                for (int i = 0; i < n; i = i + 2)
                {
                    if (double.TryParse(strArrOut[i], out dblArrOut[i]) && dblArrOut[i] != 0)
                    {
                        if (dblArrOut[i] > buf) { buf = dblArrOut[i]; }
                    }
                }
                label5.Text = buf.ToString();

            }
            else
            {
                MessageBox.Show("Вы нажали эту кнопку, хотя ещё ничего не введено");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            zap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            schit();
        }
    }
}
