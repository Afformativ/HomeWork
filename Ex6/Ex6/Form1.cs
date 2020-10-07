using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double alpha = double.Parse(textBox3.Text);
            RectangularTriangle tri = new RectangularTriangle(a, b, alpha);
            if (a > 0 && b > 0 && alpha > 0 && alpha<=90 )
            {
                double res = tri.Perimetr();
                double ar = tri.Area();
                label6.Text = Convert.ToString(res);
                label5.Text = Convert.ToString(ar);
            }
            else
            {
                label5.Text = "Error";
                label6.Text = "Error";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox4.Text);
            double b = double.Parse(textBox5.Text);
            double alpha = double.Parse(textBox6.Text);
            RectangularTriangle tri = new RectangularTriangle(a, b, alpha);
            if (a > 0 && b > 0 && alpha > 0 && alpha < 180) 
            {
                double res = tri.Perimetr();
                double ar = tri.Area();
                label11.Text = Convert.ToString(res);
                label10.Text = Convert.ToString(ar);
            }
            else
            {
                label11.Text = "Error";
                label10.Text = "Error";
            }
        }
    }
}
