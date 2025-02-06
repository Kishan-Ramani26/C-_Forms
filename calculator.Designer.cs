namespace WinFormsApp1
{
    partial class calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            seven = new Button();
            four = new Button();
            one = new Button();
            zero2 = new Button();
            zero = new Button();
            two = new Button();
            five = new Button();
            eight = new Button();
            dot = new Button();
            three = new Button();
            six = new Button();
            nine = new Button();
            divi = new Button();
            Add = new Button();
            sub = new Button();
            mulit = new Button();
            equal = new Button();
            CE = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            richTextBox1.Location = new Point(104, 75);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(339, 47);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // seven
            // 
            seven.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            seven.Location = new Point(104, 128);
            seven.Name = "seven";
            seven.Size = new Size(63, 46);
            seven.TabIndex = 1;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // four
            // 
            four.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            four.Location = new Point(104, 180);
            four.Name = "four";
            four.Size = new Size(63, 46);
            four.TabIndex = 2;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // one
            // 
            one.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            one.Location = new Point(104, 232);
            one.Name = "one";
            one.Size = new Size(63, 46);
            one.TabIndex = 3;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += button3_Click;
            // 
            // zero2
            // 
            zero2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            zero2.Location = new Point(104, 284);
            zero2.Name = "zero2";
            zero2.Size = new Size(63, 46);
            zero2.TabIndex = 4;
            zero2.Text = "00";
            zero2.UseVisualStyleBackColor = true;
            zero2.Click += button4_Click;
            // 
            // zero
            // 
            zero.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            zero.Location = new Point(173, 284);
            zero.Name = "zero";
            zero.Size = new Size(63, 46);
            zero.TabIndex = 8;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // two
            // 
            two.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            two.Location = new Point(173, 232);
            two.Name = "two";
            two.Size = new Size(63, 46);
            two.TabIndex = 7;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // five
            // 
            five.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            five.Location = new Point(173, 180);
            five.Name = "five";
            five.Size = new Size(63, 46);
            five.TabIndex = 6;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // eight
            // 
            eight.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            eight.Location = new Point(173, 128);
            eight.Name = "eight";
            eight.Size = new Size(63, 46);
            eight.TabIndex = 5;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // dot
            // 
            dot.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            dot.Location = new Point(242, 284);
            dot.Name = "dot";
            dot.Size = new Size(63, 46);
            dot.TabIndex = 12;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // three
            // 
            three.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            three.Location = new Point(242, 232);
            three.Name = "three";
            three.Size = new Size(63, 46);
            three.TabIndex = 11;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // six
            // 
            six.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            six.Location = new Point(242, 180);
            six.Name = "six";
            six.Size = new Size(63, 46);
            six.TabIndex = 10;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // nine
            // 
            nine.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            nine.Location = new Point(242, 128);
            nine.Name = "nine";
            nine.Size = new Size(63, 46);
            nine.TabIndex = 9;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // divi
            // 
            divi.BackColor = SystemColors.ControlDarkDark;
            divi.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            divi.ForeColor = SystemColors.ControlLightLight;
            divi.Location = new Point(311, 284);
            divi.Name = "divi";
            divi.Size = new Size(63, 46);
            divi.TabIndex = 16;
            divi.Text = "/";
            divi.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.ControlDarkDark;
            Add.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            Add.ForeColor = SystemColors.ControlLightLight;
            Add.Location = new Point(311, 232);
            Add.Name = "Add";
            Add.Size = new Size(63, 46);
            Add.TabIndex = 15;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = false;
            // 
            // sub
            // 
            sub.BackColor = SystemColors.ControlDarkDark;
            sub.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            sub.ForeColor = SystemColors.ControlLightLight;
            sub.Location = new Point(311, 180);
            sub.Name = "sub";
            sub.Size = new Size(63, 46);
            sub.TabIndex = 14;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = false;
            // 
            // mulit
            // 
            mulit.BackColor = SystemColors.ControlDarkDark;
            mulit.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            mulit.ForeColor = SystemColors.ControlLightLight;
            mulit.Location = new Point(311, 128);
            mulit.Name = "mulit";
            mulit.Size = new Size(63, 46);
            mulit.TabIndex = 13;
            mulit.Text = "*";
            mulit.UseVisualStyleBackColor = false;
            // 
            // equal
            // 
            equal.BackColor = SystemColors.ControlDark;
            equal.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            equal.Location = new Point(380, 180);
            equal.Name = "equal";
            equal.Size = new Size(63, 150);
            equal.TabIndex = 20;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            // 
            // CE
            // 
            CE.BackColor = Color.LightGreen;
            CE.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            CE.Location = new Point(380, 128);
            CE.Name = "CE";
            CE.Size = new Size(63, 46);
            CE.TabIndex = 17;
            CE.Text = "CE";
            CE.UseVisualStyleBackColor = false;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 450);
            Controls.Add(equal);
            Controls.Add(CE);
            Controls.Add(divi);
            Controls.Add(Add);
            Controls.Add(sub);
            Controls.Add(mulit);
            Controls.Add(dot);
            Controls.Add(three);
            Controls.Add(six);
            Controls.Add(nine);
            Controls.Add(zero);
            Controls.Add(two);
            Controls.Add(five);
            Controls.Add(eight);
            Controls.Add(zero2);
            Controls.Add(one);
            Controls.Add(four);
            Controls.Add(seven);
            Controls.Add(richTextBox1);
            Name = "calculator";
            Text = "calculator";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button seven;
        private Button four;
        private Button one;
        private Button zero2;
        private Button zero;
        private Button two;
        private Button five;
        private Button eight;
        private Button dot;
        private Button three;
        private Button six;
        private Button nine;
        private Button divi;
        private Button Add;
        private Button sub;
        private Button mulit;
        private Button equal;
        private Button CE;
    }
}