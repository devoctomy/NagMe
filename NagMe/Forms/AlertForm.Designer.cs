namespace NagMe.Forms
{
    partial class AlertForm
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
            TitleLabel = new Label();
            MessageLabel = new Label();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.BackColor = Color.IndianRed;
            TitleLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(12, 107);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(830, 75);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "ALERT TITLE";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            TitleLabel.Visible = false;
            // 
            // MessageLabel
            // 
            MessageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MessageLabel.BackColor = Color.IndianRed;
            MessageLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageLabel.ForeColor = Color.White;
            MessageLabel.Location = new Point(12, 218);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(830, 338);
            MessageLabel.TabIndex = 1;
            MessageLabel.Text = "Alert message";
            MessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            MessageLabel.Visible = false;
            // 
            // AlertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(854, 565);
            Controls.Add(MessageLabel);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlertForm";
            Text = "AlertForm";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private Label MessageLabel;
    }
}