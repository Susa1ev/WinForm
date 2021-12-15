using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Z09Wf
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int n;
        StringBuilder sb = new StringBuilder();
        StringBuilder str = new StringBuilder();
        bool flag;
        public Form1()
        {
            InitializeComponent();
        }
        void schit()
        {
            if (Int32.TryParse(textBox1.Text, out n) && n > 0)
            {
                richTextBox1.Clear();
                Random r = new Random();
                if (File.Exists("inf.dat"))
                {
                    File.Delete("inf.dat");
                }
                FileStream f = new FileStream("inf.dat", FileMode.OpenOrCreate);
                BinaryWriter fOut = new BinaryWriter(f);
                for (int i = 0; i < n; i++)
                {
                    double numbs = r.Next(-10, 9) + r.NextDouble();
                    richTextBox1.AppendText($"({i + 1})-({numbs:f4})\n");
                    fOut.Write(numbs);
                }
                fOut.Close();
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
            FileStream ff = new FileStream("inf.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(ff);
            double buf = double.MinValue;
            for (int i = 0; i < ff.Length; i += 8)
            {
                ff.Seek(i, SeekOrigin.Begin);
                double z = fIn.ReadDouble();
                int pos = (i / 8);
                if (pos % 2 == 0)
                {
                    if (z > buf)
                    {
                        buf = z;
                    }
                }

            }
            label5.Text = $"{buf:f4}";
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
