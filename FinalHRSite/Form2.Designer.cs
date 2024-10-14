namespace FinalHRSite
{
    partial class Form2
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
            EmployeeData = new DataGridView();
            Refresh = new Button();
            Create = new Button();
            button1 = new Button();
            Name = new Label();
            LeaveReq = new Button();
            ((System.ComponentModel.ISupportInitialize)EmployeeData).BeginInit();
            SuspendLayout();
            // 
            // EmployeeData
            // 
            EmployeeData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeData.Location = new Point(12, 65);
            EmployeeData.Name = "EmployeeData";
            EmployeeData.RowHeadersWidth = 51;
            EmployeeData.Size = new Size(1655, 547);
            EmployeeData.TabIndex = 0;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(12, 618);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(114, 55);
            Refresh.TabIndex = 1;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += button1_Click;
            // 
            // Create
            // 
            Create.Location = new Point(132, 618);
            Create.Name = "Create";
            Create.Size = new Size(114, 55);
            Create.TabIndex = 2;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // button1
            // 
            button1.Location = new Point(252, 618);
            button1.Name = "button1";
            button1.Size = new Size(114, 55);
            button1.TabIndex = 3;
            button1.Text = "My Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 20F);
            Name.Location = new Point(12, 9);
            Name.Name = "Name";
            Name.Size = new Size(109, 46);
            Name.TabIndex = 4;
            Name.Text = "label1";
            // 
            // LeaveReq
            // 
            LeaveReq.Location = new Point(372, 618);
            LeaveReq.Name = "LeaveReq";
            LeaveReq.Size = new Size(114, 55);
            LeaveReq.TabIndex = 5;
            LeaveReq.Text = "PTO Requests";
            LeaveReq.UseVisualStyleBackColor = true;
            LeaveReq.Click += LeaveReq_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1746, 718);
            Controls.Add(LeaveReq);
            Controls.Add(Name);
            Controls.Add(button1);
            Controls.Add(Create);
            Controls.Add(Refresh);
            Controls.Add(EmployeeData);
            this.Name.Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)EmployeeData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView EmployeeData;
        private Button Refresh;
        private Button Create;
        private Button button1;
        private Label Name;
        private Button LeaveReq;
    }
}