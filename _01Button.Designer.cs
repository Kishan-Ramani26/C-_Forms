namespace WinFormsApp1
{
    partial class _01Button
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
            Insert_BTN = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name = new TextBox();
            branch = new TextBox();
            sem = new TextBox();
            Update_BTN = new Button();
            Delete_BTN = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ID_Val = new TextBox();
            ID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Insert_BTN
            // 
            Insert_BTN.Location = new Point(78, 194);
            Insert_BTN.Name = "Insert_BTN";
            Insert_BTN.Size = new Size(68, 36);
            Insert_BTN.TabIndex = 0;
            Insert_BTN.Text = "Insert";
            Insert_BTN.UseVisualStyleBackColor = true;
            Insert_BTN.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 82);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 120);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Branch";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 165);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Sem";
            // 
            // name
            // 
            name.Location = new Point(136, 78);
            name.Name = "name";
            name.Size = new Size(497, 23);
            name.TabIndex = 4;
            name.TextChanged += name_TextChanged;
            // 
            // branch
            // 
            branch.Location = new Point(136, 120);
            branch.Name = "branch";
            branch.Size = new Size(497, 23);
            branch.TabIndex = 5;
            // 
            // sem
            // 
            sem.Location = new Point(136, 165);
            sem.Name = "sem";
            sem.Size = new Size(497, 23);
            sem.TabIndex = 6;
            // 
            // Update_BTN
            // 
            Update_BTN.Location = new Point(152, 194);
            Update_BTN.Name = "Update_BTN";
            Update_BTN.Size = new Size(68, 36);
            Update_BTN.TabIndex = 7;
            Update_BTN.Text = "Update";
            Update_BTN.UseVisualStyleBackColor = true;
            Update_BTN.Click += Update_BTN_Click;
            // 
            // Delete_BTN
            // 
            Delete_BTN.Location = new Point(226, 194);
            Delete_BTN.Name = "Delete_BTN";
            Delete_BTN.Size = new Size(68, 36);
            Delete_BTN.TabIndex = 8;
            Delete_BTN.Text = "Delete";
            Delete_BTN.UseVisualStyleBackColor = true;
            Delete_BTN.Click += Delete_BTN_Click;
            // 
            // button4
            // 
            button4.Location = new Point(309, 194);
            button4.Name = "button4";
            button4.Size = new Size(324, 36);
            button4.TabIndex = 9;
            button4.Text = "Display";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(563, 120);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID_Val
            // 
            ID_Val.Location = new Point(136, 34);
            ID_Val.Name = "ID_Val";
            ID_Val.Size = new Size(497, 23);
            ID_Val.TabIndex = 12;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(70, 38);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 11;
            ID.Text = "ID";
            // 
            // _01Button
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ID_Val);
            Controls.Add(ID);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(Delete_BTN);
            Controls.Add(Update_BTN);
            Controls.Add(sem);
            Controls.Add(branch);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Insert_BTN);
            Name = "_01Button";
            Text = "_01Button";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Insert_BTN;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox branch;
        private TextBox sem;
        private Button Update_BTN;
        private Button Delete_BTN;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox ID_Val;
        private Label ID;
    }
}