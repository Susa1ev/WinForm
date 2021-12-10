using System;
using System.Text;
using System.Windows.Forms;

namespace Z072
{
    public partial class Form1 : Form
    {
        StringBuilder sb = new StringBuilder();
        string[] words;
        int[] lengthOfWords;
        int buf = Int32.MaxValue;

        public Form1()
        {
            InitializeComponent();
        }
        void Main()
        {
            sb.Append(textBox1.Text);
            words = sb.ToString().Split();
            lengthOfWords = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                lengthOfWords[i] = words[i].Length;
                if (lengthOfWords[i] < buf) { buf = lengthOfWords[i]; }
            }
            label4.Text = "Самые короткие слова:\n";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == buf)
                {
                    label4.Text += words[i] + "\n";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
}
