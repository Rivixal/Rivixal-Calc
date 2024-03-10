using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcalc;

namespace calc
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool N2;
        public Form1()
        {
            N2 = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numbers(object sender, EventArgs e)
        {
            if (N2)
            {
                N2 = false;
                textBox1.Text = "0";
            }

            Button B = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = B.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + B.Text;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            label2.Text = "";
            listBox1.Items.Clear();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            label1.Text = $"{B.Text}";
            N1 = textBox1.Text;
            label2.Text = textBox1.Text;
            N2 = true;

            label4.Text = textBox1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {


            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "/")
            {
                res = dn1 / dn2;
            }
            if (D == "X")
            {
                res = dn1 * dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "%")
            {
                res = (dn1 * dn2 / 100);
            }
            D = "=";
            N2 = true;
            textBox1.Text = res.ToString();
            label6.Text = textBox1.Text;
            if (dn2 == 0)
            {
                textBox1.Text = "Error: You cannot divide by zero, just as it is impossible to share air with someone.";
                res = 0;
            }
            listBox1.Items.Add(dn1 + " " + label1.Text + " " + dn2 + " " + "= " + " " + res);
            label1.Text = "";
            label2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);
            textBox1.Text = res.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = 1 / dn;
            textBox1.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",")) {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            label2.Text = "";
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            about aboutShow = new about();
            aboutShow.ShowDialog();
        }
    }
}
