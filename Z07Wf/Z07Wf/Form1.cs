using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z07Wf
{
    public partial class Form1 : Form
    {
        bool flag = false;
        int bufI;
        char ch;
        StringBuilder sb = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }
        void Main()
        {
            sb.Append(textBox1.Text);
            if (char.TryParse(textBox2.Text, out ch))
            {
                for (int i = 0; i < sb.Length; i++)
                {

                    if (sb[i] == ch)
                    {
                        bufI = i + 1;
                        if (!flag)
                        {
                            label3.Text = $"Символ первый раз встретился в {i + 1} символе в строке";
                            flag = true;
                        }
                    }
                }
                label4.Text = $"Символ последний раз встретился в {bufI} символе в строке";
            }
            else
            {
                MessageBox.Show("Вы ввели не символ");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }

}