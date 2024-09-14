namespace NagMe.Forms
{
    partial class ReminderEditorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderEditorDialog));
            BottomPanel = new Panel();
            OkButton = new Button();
            CancelButton = new Button();
            ApplyButton = new Button();
            TopPanel = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            BottomPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(OkButton);
            BottomPanel.Controls.Add(CancelButton);
            BottomPanel.Controls.Add(ApplyButton);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 401);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(521, 46);
            BottomPanel.TabIndex = 4;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkButton.Location = new Point(224, 7);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(91, 27);
            OkButton.TabIndex = 7;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(321, 7);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(91, 27);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            ApplyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ApplyButton.Enabled = false;
            ApplyButton.Location = new Point(418, 7);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(91, 27);
            ApplyButton.TabIndex = 5;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(tabControl1);
            TopPanel.Dock = DockStyle.Fill;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(521, 401);
            TopPanel.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(521, 401);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(513, 373);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ReminderEditorDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 447);
            Controls.Add(TopPanel);
            Controls.Add(BottomPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReminderEditorDialog";
            Text = "NagMe - Reminder Editor";
            BottomPanel.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BottomPanel;
        private Button OkButton;
        private Button CancelButton;
        private Button ApplyButton;
        private Panel TopPanel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Button button2;
        private Button ApplyButton;
    }
}