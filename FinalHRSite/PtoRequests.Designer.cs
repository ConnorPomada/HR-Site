namespace FinalHRSite
{
    partial class PtoRequests
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
            Requests = new DataGridView();
            Approve = new Button();
            Deny = new Button();
            ((System.ComponentModel.ISupportInitialize)Requests).BeginInit();
            SuspendLayout();
            // 
            // Requests
            // 
            Requests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Requests.Location = new Point(12, 12);
            Requests.Name = "Requests";
            Requests.RowHeadersWidth = 51;
            Requests.Size = new Size(776, 391);
            Requests.TabIndex = 0;
            // 
            // Approve
            // 
            Approve.Location = new Point(12, 409);
            Approve.Name = "Approve";
            Approve.Size = new Size(94, 29);
            Approve.TabIndex = 1;
            Approve.Text = "Approve";
            Approve.UseVisualStyleBackColor = true;
            Approve.Click += Approve_Click;
            // 
            // Deny
            // 
            Deny.Location = new Point(112, 409);
            Deny.Name = "Deny";
            Deny.Size = new Size(94, 29);
            Deny.TabIndex = 2;
            Deny.Text = "Deny";
            Deny.UseVisualStyleBackColor = true;
            Deny.Click += Deny_Click;
            // 
            // PtoRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Deny);
            Controls.Add(Approve);
            Controls.Add(Requests);
            Name = "PtoRequests";
            Text = "PtoRequests";
            ((System.ComponentModel.ISupportInitialize)Requests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Requests;
        private Button Approve;
        private Button Deny;
    }
}