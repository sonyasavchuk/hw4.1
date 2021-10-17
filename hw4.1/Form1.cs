using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4._1
{
    public partial class Form1 : Form
    {
        class Triangle
        {
            protected double a, b, c;
            double alfa, beta, hama;
            public Triangle(double a,double b,double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public void ChangeSides(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public void Angles()
            {
                alfa = Math.Acos((Math.Pow(b,2)+Math.Pow(c,2)-Math.Pow(a,2)/(2*b*c)));
                beta = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2) / (2 * a* c)));
                hama = Math.Acos((Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2) / (2 * b * a)));
            }
            public double Perimeter()
            {
                return (a + b + c);
            }
        }
        class EquTriangle : Triangle
        {
            public EquTriangle(double a) : base(a, a, a) { 
            }
            double square;
            public double Square()
            {
                return (a * a * Math.Cos(Math.PI / 6));
            }
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox4.Text);
            EquTriangle t2 = new EquTriangle(a);
            MessageBox.Show("Square is "+ t2.Square());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            Triangle t1 = new Triangle(a, b, c);
            MessageBox.Show("Perimeter is "+ t1.Perimeter());
        }
    }
}
