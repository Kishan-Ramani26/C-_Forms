using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class newCalculator : Form
    {
        int value1;
        int value2;
        String operation;
        double result;


        public newCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(richTextBox1.Text);
            operation = "+";
            richTextBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(richTextBox1.Text);
            operation = "-";
            richTextBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(richTextBox1.Text);
            operation = "*";
            richTextBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(richTextBox1.Text);
            operation = "/";
            richTextBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            value2 = Convert.ToInt32(richTextBox1.Text);

            if (operation == "+")
            {
                result = value1 + value2;
                richTextBox1.Text = result.ToString();
            }
            else if (operation == "-")
            {
                result = value1 - value2;
                richTextBox1.Text = result.ToString();
            }
            else if (operation == "*")
            {
                result = value1 * value2;
                richTextBox1.Text = result.ToString();
            }
            else if (operation == "/")
            {
                result = value1 / value2;
                richTextBox1.Text = result.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            value1 = 0;
            value2 = 0;
            operation = "";
        }
    }
}
