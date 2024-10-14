namespace FinalHRSite
{
    partial class Create
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
            Name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Salary = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Title = new TextBox();
            label5 = new Label();
            JoinDate = new DateTimePicker();
            label6 = new Label();
            Add = new Button();
            Department = new ComboBox();
            Managers = new ComboBox();
            label7 = new Label();
            Password = new TextBox();
            AccessLvl = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // Name
            // 
            Name.Location = new Point(12, 32);
            Name.Name = "Name";
            Name.Size = new Size(125, 27);
            Name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Salary";
            // 
            // Salary
            // 
            Salary.Location = new Point(12, 85);
            Salary.Name = "Salary";
            Salary.Size = new Size(125, 27);
            Salary.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 7;
            label4.Text = "Title";
            // 
            // Title
            // 
            Title.Location = new Point(11, 192);
            Title.Name = "Title";
            Title.Size = new Size(125, 27);
            Title.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 222);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 9;
            label5.Text = "Manager";
            label5.Click += label5_Click;
            // 
            // JoinDate
            // 
            JoinDate.Location = new Point(11, 298);
            JoinDate.Name = "JoinDate";
            JoinDate.Size = new Size(250, 27);
            JoinDate.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 275);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 11;
            label6.Text = "Join Date";
            // 
            // Add
            // 
            Add.Location = new Point(11, 384);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 12;
            Add.Text = "Create";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Department
            // 
            Department.FormattingEnabled = true;
            Department.Location = new Point(12, 139);
            Department.Name = "Department";
            Department.Size = new Size(151, 28);
            Department.TabIndex = 13;
            // 
            // Managers
            // 
            Managers.FormattingEnabled = true;
            Managers.Location = new Point(12, 244);
            Managers.Name = "Managers";
            Managers.Size = new Size(151, 28);
            Managers.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 328);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 15;
            label7.Text = "New Password";
            // 
            // Password
            // 
            Password.Location = new Point(12, 351);
            Password.Name = "Password";
            Password.Size = new Size(125, 27);
            Password.TabIndex = 16;
            // 
            // AccessLvl
            // 
            AccessLvl.FormattingEnabled = true;
            AccessLvl.Location = new Point(142, 191);
            AccessLvl.Name = "AccessLvl";
            AccessLvl.Size = new Size(151, 28);
            AccessLvl.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(142, 169);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 17;
            label8.Text = "Access Level";
            label8.Click += label8_Click;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 441);
            Controls.Add(AccessLvl);
            Controls.Add(label8);
            Controls.Add(Password);
            Controls.Add(label7);
            Controls.Add(Managers);
            Controls.Add(Department);
            Controls.Add(Add);
            Controls.Add(label6);
            Controls.Add(JoinDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Title);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Salary);
            Controls.Add(label1);
            Controls.Add(Name);
            this.Name.Name = "Create";
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name;
        private Label label1;
        private Label label2;
        private TextBox Salary;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox Title;
        private Label label5;
        private DateTimePicker JoinDate;
        private Label label6;
        private Button Add;
        private ComboBox Department;
        private ComboBox Managers;
        private Label label7;
        private TextBox Password;
        private ComboBox AccessLvl;
        private Label label8;
    }
}