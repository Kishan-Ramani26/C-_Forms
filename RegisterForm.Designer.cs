namespace WinFormsApp1
{
    partial class RegisterForm
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
            Branch = new TextBox();
            label2 = new Label();
            Sem = new TextBox();
            label3 = new Label();
            label4 = new Label();
            citylist = new ListBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            RegisterButton = new Button();
            password = new TextBox();
            label6 = new Label();
            button1 = new Button();
            IDTXT = new TextBox();
            Id = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ShowData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 58);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Name : ";
            // 
            // name
            // 
            name.Location = new Point(161, 55);
            name.Name = "name";
            name.Size = new Size(223, 23);
            name.TabIndex = 1;
            // 
            // Branch
            // 
            Branch.Location = new Point(161, 111);
            Branch.Name = "Branch";
            Branch.Size = new Size(223, 23);
            Branch.TabIndex = 3;
            Branch.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 114);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Branch : ";
            // 
            // Sem
            // 
            Sem.Location = new Point(161, 161);
            Sem.Name = "Sem";
            Sem.Size = new Size(223, 23);
            Sem.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 164);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Sem : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 266);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "City : ";
            label4.Click += label4_Click;
            // 
            // citylist
            // 
            citylist.FormattingEnabled = true;
            citylist.ItemHeight = 15;
            citylist.Items.AddRange(new object[] { "Rajkot", "Morbi", "Ahemdabad" });
            citylist.Location = new Point(161, 266);
            citylist.Name = "citylist";
            citylist.Size = new Size(223, 94);
            citylist.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 214);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "Gender : ";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(161, 214);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(290, 214);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(85, 379);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 11;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += button1_Click;
            // 
            // password
            // 
            password.Location = new Point(476, 55);
            password.Name = "password";
            password.Size = new Size(223, 23);
            password.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 58);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 12;
            label6.Text = "Password : ";
            // 
            // button1
            // 
            button1.Location = new Point(176, 379);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // IDTXT
            // 
            IDTXT.Location = new Point(161, 26);
            IDTXT.Name = "IDTXT";
            IDTXT.Size = new Size(223, 23);
            IDTXT.TabIndex = 16;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(84, 34);
            Id.Name = "Id";
            Id.Size = new Size(27, 15);
            Id.TabIndex = 17;
            Id.Text = "ID : ";
            // 
            // button2
            // 
            button2.Location = new Point(257, 379);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(411, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(348, 206);
            dataGridView1.TabIndex = 19;
            // 
            // ShowData
            // 
            ShowData.Location = new Point(343, 384);
            ShowData.Name = "ShowData";
            ShowData.Size = new Size(75, 23);
            ShowData.TabIndex = 20;
            ShowData.Text = "showData";
            ShowData.UseVisualStyleBackColor = true;
            ShowData.Click += ShowData_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowData);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(Id);
            Controls.Add(IDTXT);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(label6);
            Controls.Add(RegisterButton);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(citylist);
            Controls.Add(label4);
            Controls.Add(Sem);
            Controls.Add(label3);
            Controls.Add(Branch);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private TextBox Branch;
        private Label label2;
        private TextBox Sem;
        private Label label3;
        private Label label4;
        private ListBox citylist;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button RegisterButton;
        private TextBox password;
        private Label label6;
        private Button button1;
        private TextBox IDTXT;
        private Label Id;
        private Button button2;
        private DataGridView dataGridView1;
        private Button ShowData;
    }
}