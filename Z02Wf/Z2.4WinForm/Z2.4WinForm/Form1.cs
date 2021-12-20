using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z2._4WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Main()
        {
            label1.Text = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4 - i; j >= 0; j--)
                {
                    label1.Text += j + "    ";
                }
                label1.Text += "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
}
