namespace FinalHRSite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            login = new Button();
            Error = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(194, 169);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(286, 27);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(194, 202);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(286, 27);
            password.TabIndex = 1;
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            password.KeyDown += password_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(286, 138);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 2;
            label1.Text = "Welcome!";
            // 
            // login
            // 
            login.Location = new Point(194, 234);
            login.Name = "login";
            login.Size = new Size(286, 29);
            login.TabIndex = 3;
            login.Text = "LOGIN";
            login.UseVisualStyleBackColor = true;
            login.Click += button1_Click;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.ForeColor = Color.Firebrick;
            Error.Location = new Point(194, 266);
            Error.Name = "Error";
            Error.Size = new Size(0, 20);
            Error.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 380);
            Controls.Add(Error);
            Controls.Add(login);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Label label1;
        private Button login;
        private Label Error;
    }
}
