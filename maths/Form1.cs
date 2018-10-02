using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maths
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int i1 = 3 * 4;
            int i2 = 12 / 4;
            int i3 = 15 / 4;
            int i4 = 15 % 4;
            int i5 = 2 + 3 * 4;
            int i6 = 2 + (3 * 4) / (2 - 4);
            double d1 = 3.1 * 2.3;
            double d2 = 1.0 / 3.0;
            double d3 = 1 / 3;

            richTextBox1.AppendText(i1 + "\n" + i2 + "\n" + i3 + "\n" + i4 + "\n" + i5 + "\n" + i6 + "\n");
            richTextBox1.AppendText(d1 + "\n" + d2 + "\n" + d3 + "\n");

            richTextBox1.AppendText (Math.Pow (27, 0.333333333) + "\n");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(textBox1.Text);
                double cubedroot = Math.Pow(d, 1.0 / 3.0);
                label1.Text = cubedroot.ToString();

            }
            catch
            {
                label1.Text = ("no numbers");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(textBox2.Text + textBox3.Text);
                double cubedroot = Math.Sqrt(d);
                label2.Text = cubedroot.ToString();
            }
            catch
            {
                label2.Text = ("no numbers");
            }
        }
    }
}
