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
            TitleLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = SystemColors.HighlightText;
            TitleLabel.Location = new Point(12, 74);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(1236, 85);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "ALERT TITLE";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MessageLabel
            // 
            MessageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MessageLabel.Font = new Font("Segoe UI Semilight", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageLabel.ForeColor = SystemColors.HighlightText;
            MessageLabel.Location = new Point(12, 245);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(1236, 451);
            MessageLabel.TabIndex = 1;
            MessageLabel.Text = "Alert message text...";
            MessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AlertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1260, 705);
            Controls.Add(MessageLabel);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlertForm";
            Opacity = 0.9D;
            Text = "AlertForm";
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private Label MessageLabel;
    }
}