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
            ReminderQueueDataGrid = new DataGridView();
            ReminderQueueDataGridColumnName = new DataGridViewTextBoxColumn();
            ReminderQueueDataGridColumnRemainingTime = new DataGridViewTextBoxColumn();
            ReminderQueueDataGridColumnTotalCount = new DataGridViewTextBoxColumn();
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
            CnclButton = new Button();
            SettingsTabs.SuspendLayout();
            RemindersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReminderQueueDataGrid).BeginInit();
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
            RemindersTab.Controls.Add(ReminderQueueDataGrid);
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
            // ReminderQueueDataGrid
            // 
            ReminderQueueDataGrid.AllowUserToAddRows = false;
            ReminderQueueDataGrid.AllowUserToDeleteRows = false;
            ReminderQueueDataGrid.AllowUserToResizeColumns = false;
            ReminderQueueDataGrid.AllowUserToResizeRows = false;
            ReminderQueueDataGrid.BackgroundColor = SystemColors.Window;
            ReminderQueueDataGrid.ColumnHeadersHeight = 24;
            ReminderQueueDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ReminderQueueDataGrid.Columns.AddRange(new DataGridViewColumn[] { ReminderQueueDataGridColumnName, ReminderQueueDataGridColumnRemainingTime, ReminderQueueDataGridColumnTotalCount });
            ReminderQueueDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            ReminderQueueDataGrid.GridColor = SystemColors.Window;
            ReminderQueueDataGrid.Location = new Point(6, 143);
            ReminderQueueDataGrid.MultiSelect = false;
            ReminderQueueDataGrid.Name = "ReminderQueueDataGrid";
            ReminderQueueDataGrid.RowHeadersVisible = false;
            ReminderQueueDataGrid.ScrollBars = ScrollBars.Vertical;
            ReminderQueueDataGrid.Size = new Size(385, 152);
            ReminderQueueDataGrid.TabIndex = 4;
            // 
            // ReminderQueueDataGridColumnName
            // 
            ReminderQueueDataGridColumnName.DataPropertyName = "Reminder";
            ReminderQueueDataGridColumnName.HeaderText = "Name";
            ReminderQueueDataGridColumnName.Name = "ReminderQueueDataGridColumnName";
            ReminderQueueDataGridColumnName.Width = 150;
            // 
            // ReminderQueueDataGridColumnRemainingTime
            // 
            ReminderQueueDataGridColumnRemainingTime.DataPropertyName = "RemainingTime";
            ReminderQueueDataGridColumnRemainingTime.HeaderText = "Remaining Time";
            ReminderQueueDataGridColumnRemainingTime.Name = "ReminderQueueDataGridColumnRemainingTime";
            // 
            // ReminderQueueDataGridColumnTotalCount
            // 
            ReminderQueueDataGridColumnTotalCount.DataPropertyName = "TotalCount";
            ReminderQueueDataGridColumnTotalCount.HeaderText = "Total Count";
            ReminderQueueDataGridColumnTotalCount.Name = "ReminderQueueDataGridColumnTotalCount";
            // 
            // DeleteReminderButton
            // 
            DeleteReminderButton.Image = Properties.Resources.Garbage_Closed_24xBlack;
            DeleteReminderButton.Location = new Point(345, 48);
            DeleteReminderButton.Name = "DeleteReminderButton";
            DeleteReminderButton.Size = new Size(48, 35);
            DeleteReminderButton.TabIndex = 2;
            DeleteReminderButton.UseVisualStyleBackColor = true;
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
            // RemindersCheckedListBox
            // 
            RemindersCheckedListBox.FormattingEnabled = true;
            RemindersCheckedListBox.Location = new Point(6, 7);
            RemindersCheckedListBox.Name = "RemindersCheckedListBox";
            RemindersCheckedListBox.Size = new Size(333, 130);
            RemindersCheckedListBox.TabIndex = 0;
            RemindersCheckedListBox.ItemCheck += RemindersCheckedListBox_ItemCheck;
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
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(OkButton);
            BottomPanel.Controls.Add(CnclButton);
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
            // 
            // CnclButton
            // 
            CnclButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CnclButton.DialogResult = DialogResult.Cancel;
            CnclButton.Location = new Point(209, 7);
            CnclButton.Name = "CnclButton";
            CnclButton.Size = new Size(91, 27);
            CnclButton.TabIndex = 3;
            CnclButton.Text = "Cancel";
            CnclButton.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)ReminderQueueDataGrid).EndInit();
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
        private Button CnclButton;
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
        private DataGridView ReminderQueueDataGrid;
        private DataGridViewTextBoxColumn ReminderQueueDataGridColumnName;
        private DataGridViewTextBoxColumn ReminderQueueDataGridColumnRemainingTime;
        private DataGridViewTextBoxColumn ReminderQueueDataGridColumnTotalCount;
    }
}
