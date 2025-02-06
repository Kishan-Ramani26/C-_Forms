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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "00";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "00";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "1";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "9";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "5";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "3";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "0";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "4";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "8";
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = ".";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + ".";
            }
        }
    }
}
