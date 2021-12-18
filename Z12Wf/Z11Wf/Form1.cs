using System;
using System.Text;
using System.Windows.Forms;

namespace Z11Wf
{
    public partial class Form1 : Form
    {
        int a, b;
        Rectangle r;
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
            label9.Text = r.A.ToString();            
            if(Int32.TryParse(textBox3.Text, out a)) { r.A = a; label10.Text = a.ToString(); r.a = a; }
            else
            {
                MessageBox.Show("Размерность стороны прямоугольника должна определяться целым положительным числом");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = r.B.ToString();
            if (Int32.TryParse(textBox4.Text, out b)) { r.B = b; label12.Text = b.ToString(); r.b = b; }
            else
            {
                MessageBox.Show("Размерность стороны прямоугольника должна определяться целым положительным числом");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            r = new Rectangle(a, b);
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
                r = new Rectangle(a, b);
                
            }
            else
            {
                MessageBox.Show("Размерность прямоугольника должна определяться целым положительным числом");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(Int32.TryParse(textBox5.Text, out i)) { label15.Text = r[i].ToString(); }
            else { MessageBox.Show("не парсится в инт"); }           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            r++;
            //++
        }

        private void button8_Click(object sender, EventArgs e)
        {
            r--;
            //--
        }

        private void button9_Click(object sender, EventArgs e)
        {
            r = (Rectangle)textBox6.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int k = 0;
            if(Int32.TryParse(textBox7.Text, out k)) { r = r * k; }
            else { MessageBox.Show("Не целочисленное"); }
        }

        void Out()
        {
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
        public int this[int index]
        {
            get
            {
                if (index == 0) return a;
                if (index == 1) return b;
                else
                {
                    MessageBox.Show("Введён неверный индекс!");
                    return 0;
                }
            }
        }
        public static Rectangle operator ++(Rectangle side) => new Rectangle(++side.a, ++side.b);
        public static Rectangle operator --(Rectangle side) => new Rectangle(--side.a, --side.b);
        public static bool operator true(Rectangle side) => side.IsSquare;
        public static bool operator false(Rectangle side) => side.IsSquare;
        public static Rectangle operator *(Rectangle side, int scl) => new Rectangle(side.a = side.a * scl, side.b = side.b * scl);
        public static explicit operator string(Rectangle side)
        {
            return ($"{side.a} {side.b}");
        }
        public static explicit operator Rectangle(string str)
        {
            string[] buf = str.Split();
            return new Rectangle(Convert.ToInt32(buf[0]), Convert.ToInt32(buf[1]));
        }

    }
}