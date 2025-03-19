namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            name = new TextBox();
            branch = new TextBox();
            label2 = new Label();
            qty = new TextBox();
            label3 = new Label();
            register_btn = new Button();
            city = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 91);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "NAME";
            // 
            // name
            // 
            name.Location = new Point(143, 88);
            name.Name = "name";
            name.Size = new Size(209, 23);
            name.TabIndex = 1;
            // 
            // branch
            // 
            branch.Location = new Point(145, 141);
            branch.Name = "branch";
            branch.Size = new Size(209, 23);
            branch.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 144);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "BRANCH";
            label2.Click += label2_Click;
            // 
            // qty
            // 
            qty.Location = new Point(145, 191);
            qty.Name = "qty";
            qty.Size = new Size(209, 23);
            qty.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 194);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "QTY";
            // 
            // register_btn
            // 
            register_btn.Location = new Point(143, 284);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(75, 23);
            register_btn.TabIndex = 6;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // city
            // 
            city.Location = new Point(143, 234);
            city.Name = "city";
            city.Size = new Size(209, 23);
            city.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 237);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "City";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(city);
            Controls.Add(label4);
            Controls.Add(register_btn);
            Controls.Add(qty);
            Controls.Add(label3);
            Controls.Add(branch);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private TextBox branch;
        private Label label2;
        private TextBox qty;
        private Label label3;
        private Button register_btn;
        private TextBox city;
        private Label label4;
    }
}