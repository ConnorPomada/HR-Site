namespace FinalHRSite
{
    partial class PtoRequester
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
            StartDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            EndDate = new DateTimePicker();
            Submit = new Button();
            Avalible = new Label();
            SuspendLayout();
            // 
            // StartDate
            // 
            StartDate.Location = new Point(12, 40);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(250, 27);
            StartDate.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 1;
            label1.Text = "PTO Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 3;
            label2.Text = "PTO End Date";
            // 
            // EndDate
            // 
            EndDate.Location = new Point(12, 101);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(250, 27);
            EndDate.TabIndex = 2;
            // 
            // Submit
            // 
            Submit.Location = new Point(12, 162);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Avalible
            // 
            Avalible.AutoSize = true;
            Avalible.Font = new Font("Segoe UI", 12F);
            Avalible.Location = new Point(12, 131);
            Avalible.Name = "Avalible";
            Avalible.Size = new Size(131, 28);
            Avalible.TabIndex = 5;
            Avalible.Text = "PTO End Date";
            // 
            // PtoRequester
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 225);
            Controls.Add(Avalible);
            Controls.Add(Submit);
            Controls.Add(label2);
            Controls.Add(EndDate);
            Controls.Add(label1);
            Controls.Add(StartDate);
            Name = "PtoRequester";
            Text = "PtoRequester";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker StartDate;
        private Label label1;
        private Label label2;
        private DateTimePicker EndDate;
        private Button Submit;
        private Label Avalible;
    }
}