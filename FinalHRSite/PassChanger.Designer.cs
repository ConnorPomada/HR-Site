namespace FinalHRSite
{
    partial class PassChanger
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
            User = new TextBox();
            OldPass = new TextBox();
            NewPass = new TextBox();
            submit = new Button();
            newpasscheck = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 0;
            label1.Text = "Change Password";
            // 
            // User
            // 
            User.Location = new Point(12, 40);
            User.Name = "User";
            User.PlaceholderText = "Username";
            User.Size = new Size(164, 27);
            User.TabIndex = 1;
            // 
            // OldPass
            // 
            OldPass.Location = new Point(12, 73);
            OldPass.Name = "OldPass";
            OldPass.PlaceholderText = "Old Password";
            OldPass.Size = new Size(164, 27);
            OldPass.TabIndex = 2;
            // 
            // NewPass
            // 
            NewPass.Location = new Point(12, 106);
            NewPass.Name = "NewPass";
            NewPass.PlaceholderText = "New Password";
            NewPass.Size = new Size(164, 27);
            NewPass.TabIndex = 3;
            // 
            // submit
            // 
            submit.Location = new Point(12, 172);
            submit.Name = "submit";
            submit.Size = new Size(164, 29);
            submit.TabIndex = 4;
            submit.Text = "Change";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // newpasscheck
            // 
            newpasscheck.Location = new Point(12, 139);
            newpasscheck.Name = "newpasscheck";
            newpasscheck.PlaceholderText = "New Password";
            newpasscheck.Size = new Size(164, 27);
            newpasscheck.TabIndex = 5;
            // 
            // PassChanger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 228);
            Controls.Add(newpasscheck);
            Controls.Add(submit);
            Controls.Add(NewPass);
            Controls.Add(OldPass);
            Controls.Add(User);
            Controls.Add(label1);
            Name = "PassChanger";
            Text = "PassChanger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox User;
        private TextBox OldPass;
        private TextBox NewPass;
        private Button submit;
        private TextBox newpasscheck;
    }
}