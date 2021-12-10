using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Z08Wf
{
    #region Сама программа
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder sb = new StringBuilder();
        string[] words;
        void Main()
        {
            Regex r = new Regex(@"(([01]?\d\d?|2[0-4]\d|25[0-5])\.){3}([01]?\d\d?|2[0-4]\d|25[0-5])");
            sb.Append(textBox1.Text);
            words = sb.ToString().Split(' ');
            label2.Text = "Все IPv4 в данном тексте: ";
            for (int i = 0; i < words.Length; i++)
            {
                if (r.IsMatch(words[i]))
                {
                    label2.Text +=words[i] + "    ";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
    #endregion
}
