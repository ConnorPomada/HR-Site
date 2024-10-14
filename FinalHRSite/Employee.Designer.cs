namespace FinalHRSite
{
    partial class Employee
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
            welcomeMsg = new Label();
            data = new Label();
            PTO = new Button();
            Requests = new DataGridView();
            label1 = new Label();
            Refresh = new Button();
            PasswordChng = new Button();
            ((System.ComponentModel.ISupportInitialize)Requests).BeginInit();
            SuspendLayout();
            // 
            // welcomeMsg
            // 
            welcomeMsg.AutoSize = true;
            welcomeMsg.Font = new Font("Segoe UI", 14F);
            welcomeMsg.Location = new Point(12, 9);
            welcomeMsg.Name = "welcomeMsg";
            welcomeMsg.Size = new Size(170, 32);
            welcomeMsg.TabIndex = 0;
            welcomeMsg.Text = "Hello, {name} !";
            // 
            // data
            // 
            data.AutoSize = true;
            data.Font = new Font("Segoe UI", 12F);
            data.Location = new Point(12, 41);
            data.Name = "data";
            data.Size = new Size(138, 28);
            data.TabIndex = 1;
            data.Text = "Hello, {name} !";
            // 
            // PTO
            // 
            PTO.Location = new Point(12, 409);
            PTO.Name = "PTO";
            PTO.Size = new Size(94, 29);
            PTO.TabIndex = 2;
            PTO.Text = "PTO";
            PTO.UseVisualStyleBackColor = true;
            PTO.Click += PTO_Click;
            // 
            // Requests
            // 
            Requests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Requests.Location = new Point(12, 215);
            Requests.Name = "Requests";
            Requests.RowHeadersWidth = 51;
            Requests.Size = new Size(724, 188);
            Requests.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 184);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 4;
            label1.Text = "Your PTO Reqests";
            // 
            // Refresh
            // 
            Refresh.Location = new Point(112, 409);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(94, 29);
            Refresh.TabIndex = 5;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // PasswordChng
            // 
            PasswordChng.Location = new Point(212, 409);
            PasswordChng.Name = "PasswordChng";
            PasswordChng.Size = new Size(168, 29);
            PasswordChng.TabIndex = 6;
            PasswordChng.Text = "Change Password";
            PasswordChng.UseVisualStyleBackColor = true;
            PasswordChng.Click += PasswordChng_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PasswordChng);
            Controls.Add(Refresh);
            Controls.Add(label1);
            Controls.Add(Requests);
            Controls.Add(PTO);
            Controls.Add(data);
            Controls.Add(welcomeMsg);
            Name = "Employee";
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)Requests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeMsg;
        private Label data;
        private Button PTO;
        private DataGridView Requests;
        private Label label1;
        private Button Refresh;
        private Button PasswordChng;
    }
}