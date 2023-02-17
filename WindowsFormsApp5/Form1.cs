using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            double x = double.Parse(textBox1.Text);
            textBox4.Text += "X= " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y= " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z= " + z.ToString();

            double a = Math.Abs(x - y) * 3 + x + Math.Pow(x, 2);
            double b = Math.Abs(x - y) * z + Math.Pow(x, 2);
            double c = - 0.25 * Math.Cosh  (x);
            double d = 5 * Math.Tanh(x);
            double k = (a / b) * c;
            double l = d * k;
            textBox4.Text += Environment.NewLine + "b = " + b.ToString();
            textBox4.Text += Environment.NewLine + "a = " + a.ToString();
            textBox4.Text += Environment.NewLine + "d = " + d.ToString();
            textBox4.Text += Environment.NewLine + "c = " + c.ToString();
            textBox4.Text += Environment.NewLine + "k = " + k.ToString();
            textBox4.Text += Environment.NewLine + "l = " + l.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
