using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            Triangle tri = new Triangle();
            double res = tri.Perimetr(a, b, c);
            bool t = tri.Proverka(a, b, c);
            if (t == true)
            {
                label4.Text = Convert.ToString(res);
            }
            else
            {
                label4.Text = "Error";
            }
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            EquilateralTriange tri = new EquilateralTriange();
            double area = tri.Area(a, b, c);
            bool t = tri.Proverka(a, b, c);
            if (t == true)
            {
                if (a == b && b == c && a == c)
                {
                    label6.Text = Convert.ToString(area);
                }
                else
                {
                    label6.Text = "Not an EquilateralTriange";
                }
            }
            else
            {
                label6.Text = "Error";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            Triangle tri = new Triangle();
            double angle = tri.Angles(a, b, c);
            bool t = tri.Proverka(a, b, c);
            if (t == true)
            {
                label5.Text = Convert.ToString(angle);
            }
            else
            {
                label5.Text = "Error";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
