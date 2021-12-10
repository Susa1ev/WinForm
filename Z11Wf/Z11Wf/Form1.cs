using System;
using System.Text;
using System.Windows.Forms;

namespace Z11Wf
{
    public partial class Form1 : Form
    {
        int a, b;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Out();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(a, b);
            label9.Text = r.A.ToString();            
            if(Int32.TryParse(textBox3.Text, out a)) { r.A = a; label10.Text = a.ToString(); r.a = a; }
            else
            {
                MessageBox.Show("Размерность стороны прямоугольника должна определяться целым положительным числом");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(a, b);
            label11.Text = r.B.ToString();
            if (Int32.TryParse(textBox4.Text, out b)) { r.B = b; label12.Text = b.ToString(); r.b = b; }
            else
            {
                MessageBox.Show("Размерность стороны прямоугольника должна определяться целым положительным числом");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(a, b);
            if(r.IsSquare)
            {
                label13.Text = "Да";
            }
            else
            {
                label13.Text = "Нет";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            In();
        }

        void In()
        {

            if (Int32.TryParse(textBox1.Text, out a) && Int32.TryParse(textBox2.Text, out b) && a > 0 && b > 0)
            {
                Rectangle r = new Rectangle(a, b);
                
            }
            else
            {
                MessageBox.Show("Размерность прямоугольника должна определяться целым положительным числом");
            }
        }
        void Out()
        {
            Rectangle r = new Rectangle(a, b);
            label4.Text = r.Out();
        }
    }
    class Rectangle
    {
        public int a, b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public string Out()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("a = " + a); sb.Append("\n");
            sb.Append("b = " + b); sb.Append("\n");
            sb.Append("Периметр = " + Per()); sb.Append("\n");
            sb.Append("Площадь = " + Area()); sb.Append("\n");
            return sb.ToString();
        }
        public int Per()
        {
            return a + a + b + b;
        }
        public int Area()
        {
            return a * b;
        }
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public bool IsSquare
        {
            get
            {
                if (a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}