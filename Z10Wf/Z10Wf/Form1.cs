using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z10Wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Main()
        {
            try
            {

                string strTxt1 = "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов", strTxt2 = "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс";
                StringBuilder strTxt3 = new StringBuilder();
                string path1 = @"C:\temp\K1\";
                string path2 = @"C:\temp\K2\";
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\temp");
                richTextBox2.Text = string.Empty;
                strTxt3.Append(strTxt1);
                strTxt3.Append("\n");
                strTxt3.Append(strTxt2);

                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                else
                {
                    dirInfo.Delete(true);
                    dirInfo.Create();
                }                
                dirInfo.CreateSubdirectory("K1");
                FileStream txt1 = File.Create(path1 + @"\t1.txt");
                txt1.Close();
                StreamWriter sw1 = new StreamWriter(path1 + @"\t1.txt");
                sw1.WriteLine(strTxt1);
                dirInfo.CreateSubdirectory("K2");
                FileStream txt2 = File.Create(path1 + @"\t2.txt");
                txt2.Close();
                FileStream txt3 = File.Create(path2 + @"\t3.txt");
                txt3.Close();
                StreamWriter sw2 = new StreamWriter(path1 + @"\t2.txt", false);
                StreamWriter sw3 = new StreamWriter(path2 + @"\t3.txt", false);
                sw2.WriteLine(strTxt2);
                sw1.Close();
                sw2.Close();
                sw3.Write(strTxt3.ToString());
                sw3.Close();
                StreamReader sr1 = new StreamReader(path1 + @"\t1.txt");
                richTextBox2.AppendText(@"Первый файл с распололжением C:\temp\K1\t1.txt"); richTextBox2.AppendText("\n");                
                richTextBox2.AppendText(sr1.ReadToEnd().ToString()); richTextBox2.AppendText("\n");
                richTextBox2.AppendText(@"Второй файл с распололжением C:\temp\K1\t2.txt"); richTextBox2.AppendText("\n");
                StreamReader sr2 = new StreamReader(path1 + @"\t2.txt");
                richTextBox2.AppendText(sr2.ReadToEnd().ToString()); richTextBox2.AppendText("\n");
                richTextBox2.AppendText(@"Третий файл с распололжением C:\temp\K2\t3.txt"); richTextBox2.AppendText("\n");
                StreamReader sr3 = new StreamReader(path2 + @"\t3.txt");
                richTextBox2.AppendText(sr3.ReadToEnd().ToString()); richTextBox2.AppendText("\n");
                sr1.Close();
                sr2.Close();
                sr3.Close();
                File.Move(path1 + @"\t1.txt", path2 + @"\t1.txt");
                File.Move(path1 + @"\t2.txt", path2 + @"\t2.txt");
                Directory.Move(path2, @"C:\temp\ALL");
                Directory.Delete(@"C:\temp\K1", true);
                string[] files = Directory.GetFiles(@"C:\temp\ALL");
                foreach (string File in files)
                {
                    richTextBox2.AppendText(File); richTextBox2.AppendText("\n");
                }

            }
            catch
            {
                MessageBox.Show("Какая-то ошибка");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
}
