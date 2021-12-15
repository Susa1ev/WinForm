using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;


namespace Z092
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int k1, k2;
        string[] line;
        StringBuilder sb = new StringBuilder();

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
        void Main()
        {

            try
            {
                if     (Int32.TryParse(textBox1.Text, out k1) &&
                        Int32.TryParse(textBox2.Text, out k2) &&
                        k2 > k1 && k1 > 0)
                {
                    line = File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Mavrodi.txt");
                    for (int i = k1; i <= k2; i++)
                    {
                        sb.Append("\n");
                        sb.Append(line[i]);
                    }
                    richTextBox1.Text = sb.ToString();
                    sb.Clear();
                }
                else
                {
                    MessageBox.Show("К1 должна быть положительной и меньше К2");
                }

            }
            catch
            {
                richTextBox1.Text = sb.ToString();
                MessageBox.Show("Вы ввели К2 больше, чем существует строк в файле, но мы вывели вам все существующие от К1 до конца");
            }
        }
    }
}

