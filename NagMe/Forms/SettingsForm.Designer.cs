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
            ToggleReminderEnabledButton = new Button();
            ReminderQueueDataGrid = new DataGridView();
            ReminderQueueDataGridColumnEnabled = new DataGridViewCheckBoxColumn();
            ReminderQueueDataGridColumnName = new DataGridViewTextBoxColumn();
            ReminderQueueDataGridColumnRemainingTime = new DataGridViewTextBoxColumn();
            ReminderQueueDataGridColumnTotalCount = new DataGridViewTextBoxColumn();
            DeleteReminderButton = new Button();
            AddReminderButton = new Button();
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
            EditReminderButton = new Button();
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
            SettingsTabs.Size = new Size(496, 329);
            SettingsTabs.TabIndex = 0;
            // 
            // RemindersTab
            // 
            RemindersTab.Controls.Add(EditReminderButton);
            RemindersTab.Controls.Add(ToggleReminderEnabledButton);
            RemindersTab.Controls.Add(ReminderQueueDataGrid);
            RemindersTab.Controls.Add(DeleteReminderButton);
            RemindersTab.Controls.Add(AddReminderButton);
            RemindersTab.Location = new Point(4, 24);
            RemindersTab.Name = "RemindersTab";
            RemindersTab.Padding = new Padding(3);
            RemindersTab.Size = new Size(488, 301);
            RemindersTab.TabIndex = 0;
            RemindersTab.Text = "Reminders";
            RemindersTab.UseVisualStyleBackColor = true;
            // 
            // ToggleReminderEnabledButton
            // 
            ToggleReminderEnabledButton.Image = Properties.Resources.Power_Off_WF_24xBlack;
            ToggleReminderEnabledButton.Location = new Point(432, 129);
            ToggleReminderEnabledButton.Name = "ToggleReminderEnabledButton";
            ToggleReminderEnabledButton.Size = new Size(48, 34);
            ToggleReminderEnabledButton.TabIndex = 5;
            ToggleReminderEnabledButton.UseVisualStyleBackColor = true;
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
            ReminderQueueDataGrid.Columns.AddRange(new DataGridViewColumn[] { ReminderQueueDataGridColumnEnabled, ReminderQueueDataGridColumnName, ReminderQueueDataGridColumnRemainingTime, ReminderQueueDataGridColumnTotalCount });
            ReminderQueueDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            ReminderQueueDataGrid.GridColor = SystemColors.Window;
            ReminderQueueDataGrid.Location = new Point(6, 6);
            ReminderQueueDataGrid.MultiSelect = false;
            ReminderQueueDataGrid.Name = "ReminderQueueDataGrid";
            ReminderQueueDataGrid.RowHeadersVisible = false;
            ReminderQueueDataGrid.ScrollBars = ScrollBars.Vertical;
            ReminderQueueDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReminderQueueDataGrid.Size = new Size(420, 289);
            ReminderQueueDataGrid.TabIndex = 4;
            // 
            // ReminderQueueDataGridColumnEnabled
            // 
            ReminderQueueDataGridColumnEnabled.DataPropertyName = "IsEnabled";
            ReminderQueueDataGridColumnEnabled.FillWeight = 50F;
            ReminderQueueDataGridColumnEnabled.HeaderText = "";
            ReminderQueueDataGridColumnEnabled.Name = "ReminderQueueDataGridColumnEnabled";
            ReminderQueueDataGridColumnEnabled.Width = 25;
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
            DeleteReminderButton.Location = new Point(432, 88);
            DeleteReminderButton.Name = "DeleteReminderButton";
            DeleteReminderButton.Size = new Size(48, 35);
            DeleteReminderButton.TabIndex = 2;
            DeleteReminderButton.UseVisualStyleBackColor = true;
            // 
            // AddReminderButton
            // 
            AddReminderButton.Image = Properties.Resources.Add_New_24xBlack;
            AddReminderButton.Location = new Point(432, 6);
            AddReminderButton.Name = "AddReminderButton";
            AddReminderButton.Size = new Size(48, 35);
            AddReminderButton.TabIndex = 1;
            AddReminderButton.UseVisualStyleBackColor = true;
            // 
            // SystemTab
            // 
            SystemTab.Controls.Add(SystemStartWithWindowsCheckBox);
            SystemTab.Location = new Point(4, 24);
            SystemTab.Name = "SystemTab";
            SystemTab.Padding = new Padding(3);
            SystemTab.Size = new Size(488, 301);
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
            AiTab.Size = new Size(488, 301);
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
            AiFeaturesPanel.Size = new Size(480, 78);
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
            AiOpenAiApiTokenTextBox.Size = new Size(457, 23);
            AiOpenAiApiTokenTextBox.TabIndex = 5;
            // 
            // AiWarningLabel
            // 
            AiWarningLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AiWarningLabel.ForeColor = Color.Red;
            AiWarningLabel.Location = new Point(20, 16);
            AiWarningLabel.Name = "AiWarningLabel";
            AiWarningLabel.Size = new Size(457, 115);
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
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(SettingsTabs);
            TopPanel.Dock = DockStyle.Fill;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(496, 329);
            TopPanel.TabIndex = 1;
            // 
            // ApplyButton
            // 
            ApplyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ApplyButton.Enabled = false;
            ApplyButton.Location = new Point(393, 7);
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
            BottomPanel.Size = new Size(496, 46);
            BottomPanel.TabIndex = 3;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkButton.Location = new Point(199, 7);
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
            CnclButton.Location = new Point(296, 7);
            CnclButton.Name = "CnclButton";
            CnclButton.Size = new Size(91, 27);
            CnclButton.TabIndex = 3;
            CnclButton.Text = "Cancel";
            CnclButton.UseVisualStyleBackColor = true;
            // 
            // EditReminderButton
            // 
            EditReminderButton.Image = Properties.Resources.Data_Edit_24xblack;
            EditReminderButton.Location = new Point(432, 47);
            EditReminderButton.Name = "EditReminderButton";
            EditReminderButton.Size = new Size(48, 35);
            EditReminderButton.TabIndex = 6;
            EditReminderButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 375);
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
        private Button DeleteReminderButton;
        private TabPage AiTab;
        private CheckBox AiEnableCheckBox;
        private Label AiWarningLabel;
        private Panel AiFeaturesPanel;
        private Label AiOpenAiApiTokenLabel;
        private TextBox AiOpenAiApiTokenTextBox;
        private DataGridView ReminderQueueDataGrid;
        private DataGridViewCheckBoxColumn ReminderQueueDataGridColumnEnabled;
        private DataGridViewTextBoxColumn ReminderQueueDataGridColumnName;
        private DataGridViewTextBoxColumn ReminderQueueDataGridColumnRemainingTime;
        private DataGridViewTextBoxColumn ReminderQueueDataGridColumnTotalCount;
        private Button ToggleReminderEnabledButton;
        private Button EditReminderButton;
    }
}
