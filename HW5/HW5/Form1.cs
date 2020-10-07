using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectedTab = tabPage2;
           
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            switch (a)
            {

                case "Triangle":
                    tabControl1.SelectedTab = tabPage1;
                    break;
                case "Rectangle":
                    tabControl1.SelectedTab = tabPage3;
                    break;
                case "Circle":
                    tabControl1.SelectedTab = tabPage6;
                    break;
                case "Rhombus":
                    tabControl1.SelectedTab = tabPage5;
                    break;
                case "Square":
                    tabControl1.SelectedTab = tabPage4;
                    break;
                default:
                    tabControl1.SelectedTab = tabPage2;
                    break;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox2.Text);
            double b = double.Parse(textBox3.Text);
            double c = double.Parse(textBox4.Text);
            Triangle tri = new Triangle(a,b,c);
            if (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < a + b ) 
            {
                double res = tri.Perimetr();
                double ar = tri.Area();
                label5.Text = Convert.ToString(res);
                label6.Text = Convert.ToString(ar);
            }
            else
            {
                label5.Text = "Error";
                label6.Text = "Error";
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox5.Text);
            double d1 = double.Parse(textBox6.Text);
            double d2 = double.Parse(textBox7.Text);
            Rhombus tri = new Rhombus(a, d1, d2);
            if (a > 0 && d1 > 0 && d2 > 0)
            {
                double res = tri.Perimetr();
                double ar = tri.Area();
                label10.Text = Convert.ToString(res);
                label11.Text = Convert.ToString(ar);
            }
            else
            {
                label10.Text = "Error";
                label11.Text = "Error";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBox8.Text); 
            Circle tri = new Circle(r);
            if (r > 0)
            {
                double res = tri.Perimetr();
                double ar = tri.Area();
                label13.Text = Convert.ToString(res);
                label14.Text = Convert.ToString(ar);
            }
            else
            {
                label13.Text = "Error";
                label14.Text = "Error";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox9.Text);
            Square tri = new Square(a);
            if (a > 0)
            {
                double res = tri.Perimetr();
                double ar = tri.Area();
                label17.Text = Convert.ToString(res);
                label16.Text = Convert.ToString(ar);
            }
            else
            {
                label16.Text = "Error";
                label17.Text = "Error";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox10.Text);
            double b = double.Parse(textBox11.Text);
            Rectangle tri = new Rectangle(a, b);
            if (a > 0 && b > 0)
            {
                double res = tri.Perimetr();
                double ar = tri.Area();
                label20.Text = Convert.ToString(res);
                label21.Text = Convert.ToString(ar);
            }
            else
            {
                label20.Text = "Error";
                label21.Text = "Error";
            }
        }

    }
    }

