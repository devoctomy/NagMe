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
            RemindersTab = new TabPage();
            DeleteReminderButton = new Button();
            AddReminderButton = new Button();
            RemindersCheckedListBox = new CheckedListBox();
            SystemTab = new TabPage();
            SystemStartWithWindowsCheckBox = new CheckBox();
            AiTab = new TabPage();
            AiFeaturesPanel = new Panel();
            AiOpenAiApiTokenLabel = new Label();
            AiOpenAiApiTokenTextBox = new TextBox();
            AiWarningLabel = new Label();
            AiEnableCheckBox = new CheckBox();
            TopPanel = new Panel();
            ApplyButton = new Button();
            BottomPanel = new Panel();
            OkButton = new Button();
            CancelButton = new Button();
            RemindersQueueListView = new ListView();
            NameHeader = new ColumnHeader();
            RemainingTimeHeader = new ColumnHeader();
            TotalCountHeader = new ColumnHeader();
            SettingsTabs.SuspendLayout();
            RemindersTab.SuspendLayout();
            SystemTab.SuspendLayout();
            AiTab.SuspendLayout();
            AiFeaturesPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsTabs
            // 
            SettingsTabs.Controls.Add(RemindersTab);
            SettingsTabs.Controls.Add(SystemTab);
            SettingsTabs.Controls.Add(AiTab);
            SettingsTabs.Dock = DockStyle.Fill;
            SettingsTabs.Location = new Point(0, 0);
            SettingsTabs.Name = "SettingsTabs";
            SettingsTabs.SelectedIndex = 0;
            SettingsTabs.Size = new Size(409, 329);
            SettingsTabs.TabIndex = 0;
            // 
            // RemindersTab
            // 
            RemindersTab.Controls.Add(RemindersQueueListView);
            RemindersTab.Controls.Add(DeleteReminderButton);
            RemindersTab.Controls.Add(AddReminderButton);
            RemindersTab.Controls.Add(RemindersCheckedListBox);
            RemindersTab.Location = new Point(4, 24);
            RemindersTab.Name = "RemindersTab";
            RemindersTab.Padding = new Padding(3);
            RemindersTab.Size = new Size(401, 301);
            RemindersTab.TabIndex = 0;
            RemindersTab.Text = "Reminders";
            RemindersTab.UseVisualStyleBackColor = true;
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
            // AddReminderButton
            // 
            AddReminderButton.Image = Properties.Resources.Add_New_24xBlack;
            AddReminderButton.Location = new Point(345, 7);
            AddReminderButton.Name = "AddReminderButton";
            AddReminderButton.Size = new Size(48, 35);
            AddReminderButton.TabIndex = 1;
            AddReminderButton.UseVisualStyleBackColor = true;
            AddReminderButton.Click += AddReminderButton_Click;
            // 
            // RemindersCheckedListBox
            // 
            RemindersCheckedListBox.FormattingEnabled = true;
            RemindersCheckedListBox.Location = new Point(6, 7);
            RemindersCheckedListBox.Name = "RemindersCheckedListBox";
            RemindersCheckedListBox.Size = new Size(333, 130);
            RemindersCheckedListBox.TabIndex = 0;
            RemindersCheckedListBox.SelectedValueChanged += RemindersCheckedListBox_SelectedValueChanged;
            // 
            // SystemTab
            // 
            SystemTab.Controls.Add(SystemStartWithWindowsCheckBox);
            SystemTab.Location = new Point(4, 24);
            SystemTab.Name = "SystemTab";
            SystemTab.Padding = new Padding(3);
            SystemTab.Size = new Size(401, 301);
            SystemTab.TabIndex = 1;
            SystemTab.Text = "System";
            SystemTab.UseVisualStyleBackColor = true;
            // 
            // SystemStartWithWindowsCheckBox
            // 
            SystemStartWithWindowsCheckBox.AutoSize = true;
            SystemStartWithWindowsCheckBox.Location = new Point(20, 17);
            SystemStartWithWindowsCheckBox.Name = "SystemStartWithWindowsCheckBox";
            SystemStartWithWindowsCheckBox.Size = new Size(130, 19);
            SystemStartWithWindowsCheckBox.TabIndex = 0;
            SystemStartWithWindowsCheckBox.Text = "Start With Windows";
            SystemStartWithWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // AiTab
            // 
            AiTab.Controls.Add(AiFeaturesPanel);
            AiTab.Controls.Add(AiWarningLabel);
            AiTab.Controls.Add(AiEnableCheckBox);
            AiTab.Location = new Point(4, 24);
            AiTab.Name = "AiTab";
            AiTab.Size = new Size(401, 301);
            AiTab.TabIndex = 2;
            AiTab.Text = "AI";
            AiTab.UseVisualStyleBackColor = true;
            // 
            // AiFeaturesPanel
            // 
            AiFeaturesPanel.Controls.Add(AiOpenAiApiTokenLabel);
            AiFeaturesPanel.Controls.Add(AiOpenAiApiTokenTextBox);
            AiFeaturesPanel.Enabled = false;
            AiFeaturesPanel.Location = new Point(0, 162);
            AiFeaturesPanel.Name = "AiFeaturesPanel";
            AiFeaturesPanel.Size = new Size(401, 78);
            AiFeaturesPanel.TabIndex = 5;
            // 
            // AiOpenAiApiTokenLabel
            // 
            AiOpenAiApiTokenLabel.AutoSize = true;
            AiOpenAiApiTokenLabel.Location = new Point(20, 12);
            AiOpenAiApiTokenLabel.Name = "AiOpenAiApiTokenLabel";
            AiOpenAiApiTokenLabel.Size = new Size(102, 15);
            AiOpenAiApiTokenLabel.TabIndex = 6;
            AiOpenAiApiTokenLabel.Text = "OpenAI API Token";
            // 
            // AiOpenAiApiTokenTextBox
            // 
            AiOpenAiApiTokenTextBox.Location = new Point(20, 39);
            AiOpenAiApiTokenTextBox.Name = "AiOpenAiApiTokenTextBox";
            AiOpenAiApiTokenTextBox.Size = new Size(373, 23);
            AiOpenAiApiTokenTextBox.TabIndex = 5;
            // 
            // AiWarningLabel
            // 
            AiWarningLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AiWarningLabel.ForeColor = Color.Red;
            AiWarningLabel.Location = new Point(20, 16);
            AiWarningLabel.Name = "AiWarningLabel";
            AiWarningLabel.Size = new Size(359, 115);
            AiWarningLabel.TabIndex = 2;
            AiWarningLabel.Text = resources.GetString("AiWarningLabel.Text");
            // 
            // AiEnableCheckBox
            // 
            AiEnableCheckBox.AutoSize = true;
            AiEnableCheckBox.Location = new Point(20, 137);
            AiEnableCheckBox.Name = "AiEnableCheckBox";
            AiEnableCheckBox.Size = new Size(122, 19);
            AiEnableCheckBox.TabIndex = 1;
            AiEnableCheckBox.Text = "Enable AI Features";
            AiEnableCheckBox.UseVisualStyleBackColor = true;
            AiEnableCheckBox.CheckedChanged += AiEnableCheckBox_CheckedChanged;
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
            // RemindersQueueListView
            // 
            RemindersQueueListView.Columns.AddRange(new ColumnHeader[] { NameHeader, RemainingTimeHeader, TotalCountHeader });
            RemindersQueueListView.Location = new Point(8, 143);
            RemindersQueueListView.MultiSelect = false;
            RemindersQueueListView.Name = "RemindersQueueListView";
            RemindersQueueListView.Size = new Size(385, 152);
            RemindersQueueListView.TabIndex = 3;
            RemindersQueueListView.UseCompatibleStateImageBehavior = false;
            RemindersQueueListView.View = View.Details;
            // 
            // NameHeader
            // 
            NameHeader.Text = "Name";
            NameHeader.Width = 150;
            // 
            // RemainingTimeHeader
            // 
            RemainingTimeHeader.Text = "Remaining Time";
            RemainingTimeHeader.Width = 100;
            // 
            // TotalCountHeader
            // 
            TotalCountHeader.Text = "TotalCount";
            TotalCountHeader.Width = 100;
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
            RemindersTab.ResumeLayout(false);
            SystemTab.ResumeLayout(false);
            SystemTab.PerformLayout();
            AiTab.ResumeLayout(false);
            AiTab.PerformLayout();
            AiFeaturesPanel.ResumeLayout(false);
            AiFeaturesPanel.PerformLayout();
            TopPanel.ResumeLayout(false);
            BottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl SettingsTabs;
        private TabPage RemindersTab;
        private TabPage SystemTab;
        private Panel TopPanel;
        private Button ApplyButton;
        private Panel BottomPanel;
        private Button OkButton;
        private Button CancelButton;
        private CheckBox SystemStartWithWindowsCheckBox;
        private Button AddReminderButton;
        private CheckedListBox RemindersCheckedListBox;
        private Button DeleteReminderButton;
        private TabPage AiTab;
        private CheckBox AiEnableCheckBox;
        private Label AiWarningLabel;
        private Panel AiFeaturesPanel;
        private Label AiOpenAiApiTokenLabel;
        private TextBox AiOpenAiApiTokenTextBox;
        private ListView RemindersQueueListView;
        private ColumnHeader NameHeader;
        private ColumnHeader RemainingTimeHeader;
        private ColumnHeader TotalCountHeader;
    }
}
