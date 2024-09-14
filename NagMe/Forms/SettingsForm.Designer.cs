namespace NagMe.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            SettingsTabs = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            StartWithWindowsCheckBox = new CheckBox();
            TopPanel = new Panel();
            ApplyButton = new Button();
            BottomPanel = new Panel();
            OkButton = new Button();
            CancelButton = new Button();
            checkedListBox1 = new CheckedListBox();
            AddReminderButton = new Button();
            DeleteReminderButton = new Button();
            SettingsTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            TopPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsTabs
            // 
            SettingsTabs.Controls.Add(tabPage1);
            SettingsTabs.Controls.Add(tabPage2);
            SettingsTabs.Dock = DockStyle.Fill;
            SettingsTabs.Location = new Point(0, 0);
            SettingsTabs.Name = "SettingsTabs";
            SettingsTabs.SelectedIndex = 0;
            SettingsTabs.Size = new Size(409, 329);
            SettingsTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DeleteReminderButton);
            tabPage1.Controls.Add(AddReminderButton);
            tabPage1.Controls.Add(checkedListBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(401, 301);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reminders";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(StartWithWindowsCheckBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(401, 301);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "System";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // StartWithWindowsCheckBox
            // 
            StartWithWindowsCheckBox.AutoSize = true;
            StartWithWindowsCheckBox.Location = new Point(20, 17);
            StartWithWindowsCheckBox.Name = "StartWithWindowsCheckBox";
            StartWithWindowsCheckBox.Size = new Size(130, 19);
            StartWithWindowsCheckBox.TabIndex = 0;
            StartWithWindowsCheckBox.Text = "Start With Windows";
            StartWithWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(SettingsTabs);
            TopPanel.Dock = DockStyle.Fill;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(409, 329);
            TopPanel.TabIndex = 1;
            // 
            // ApplyButton
            // 
            ApplyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ApplyButton.Enabled = false;
            ApplyButton.Location = new Point(306, 7);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(91, 27);
            ApplyButton.TabIndex = 2;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(OkButton);
            BottomPanel.Controls.Add(CancelButton);
            BottomPanel.Controls.Add(ApplyButton);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 329);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(409, 46);
            BottomPanel.TabIndex = 3;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkButton.Location = new Point(112, 7);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(91, 27);
            OkButton.TabIndex = 4;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(209, 7);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(91, 27);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(6, 7);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(333, 274);
            checkedListBox1.TabIndex = 0;
            // 
            // AddReminderButton
            // 
            AddReminderButton.Image = Properties.Resources.Add_New_24xBlack;
            AddReminderButton.Location = new Point(345, 7);
            AddReminderButton.Name = "AddReminderButton";
            AddReminderButton.Size = new Size(48, 35);
            AddReminderButton.TabIndex = 1;
            AddReminderButton.UseVisualStyleBackColor = true;
            // 
            // DeleteReminderButton
            // 
            DeleteReminderButton.Image = Properties.Resources.Garbage_Closed_24xBlack;
            DeleteReminderButton.Location = new Point(345, 48);
            DeleteReminderButton.Name = "DeleteReminderButton";
            DeleteReminderButton.Size = new Size(48, 35);
            DeleteReminderButton.TabIndex = 2;
            DeleteReminderButton.UseVisualStyleBackColor = true;
            DeleteReminderButton.Click += DeleteReminderButton_Click;
            // 
            // SettingsForm
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 375);
            Controls.Add(TopPanel);
            Controls.Add(BottomPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NagMe - Settings";
            SettingsTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            TopPanel.ResumeLayout(false);
            BottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl SettingsTabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel TopPanel;
        private Button ApplyButton;
        private Panel BottomPanel;
        private Button OkButton;
        private Button CancelButton;
        private CheckBox StartWithWindowsCheckBox;
        private Button AddReminderButton;
        private CheckedListBox checkedListBox1;
        private Button DeleteReminderButton;
    }
}
