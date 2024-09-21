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
            EditReminderButton = new Button();
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
            AIAlertPanel = new Panel();
            AiWarningLabel = new Label();
            AiFeaturesPanel = new Panel();
            AIAlertAudioNumericUpDown = new NumericUpDown();
            AIAlertAudioLabel = new Label();
            AIAlertImagesNumericUpDown = new NumericUpDown();
            AIAlertImagesLabel = new Label();
            AIAlertMessagesNumericUpDown = new NumericUpDown();
            AIAlertMessagesLabel = new Label();
            AICachedResourceLimitsLabel = new Label();
            AIAlertTitlesNumericUpDown = new NumericUpDown();
            AIAlertTitlesLabel = new Label();
            AIResourceLifeTimePeriodComboBox = new ComboBox();
            AIResourceLifeTimeNumericUpDown = new NumericUpDown();
            AiOpenAiResourceLifeTimeLabel = new Label();
            AiOpenAiApiTokenLabel = new Label();
            AiOpenAiApiTokenTextBox = new TextBox();
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
            AIAlertPanel.SuspendLayout();
            AiFeaturesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AIAlertAudioNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AIAlertImagesNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AIAlertMessagesNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AIAlertTitlesNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AIResourceLifeTimeNumericUpDown).BeginInit();
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
            SettingsTabs.Size = new Size(496, 517);
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
            RemindersTab.Size = new Size(488, 489);
            RemindersTab.TabIndex = 0;
            RemindersTab.Text = "Reminders";
            RemindersTab.UseVisualStyleBackColor = true;
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
            ReminderQueueDataGrid.Size = new Size(420, 477);
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
            SystemTab.Size = new Size(488, 489);
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
            AiTab.Controls.Add(AIAlertPanel);
            AiTab.Controls.Add(AiFeaturesPanel);
            AiTab.Controls.Add(AiEnableCheckBox);
            AiTab.Location = new Point(4, 24);
            AiTab.Name = "AiTab";
            AiTab.Size = new Size(488, 489);
            AiTab.TabIndex = 2;
            AiTab.Text = "AI";
            AiTab.UseVisualStyleBackColor = true;
            // 
            // AIAlertPanel
            // 
            AIAlertPanel.BackColor = Color.FromArgb(255, 192, 192);
            AIAlertPanel.Controls.Add(AiWarningLabel);
            AIAlertPanel.Location = new Point(8, 3);
            AIAlertPanel.Name = "AIAlertPanel";
            AIAlertPanel.Size = new Size(472, 128);
            AIAlertPanel.TabIndex = 6;
            // 
            // AiWarningLabel
            // 
            AiWarningLabel.Dock = DockStyle.Fill;
            AiWarningLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AiWarningLabel.ForeColor = SystemColors.ControlText;
            AiWarningLabel.Location = new Point(0, 0);
            AiWarningLabel.Name = "AiWarningLabel";
            AiWarningLabel.Size = new Size(472, 128);
            AiWarningLabel.TabIndex = 2;
            AiWarningLabel.Text = resources.GetString("AiWarningLabel.Text");
            AiWarningLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AiFeaturesPanel
            // 
            AiFeaturesPanel.Controls.Add(AIAlertAudioNumericUpDown);
            AiFeaturesPanel.Controls.Add(AIAlertAudioLabel);
            AiFeaturesPanel.Controls.Add(AIAlertImagesNumericUpDown);
            AiFeaturesPanel.Controls.Add(AIAlertImagesLabel);
            AiFeaturesPanel.Controls.Add(AIAlertMessagesNumericUpDown);
            AiFeaturesPanel.Controls.Add(AIAlertMessagesLabel);
            AiFeaturesPanel.Controls.Add(AICachedResourceLimitsLabel);
            AiFeaturesPanel.Controls.Add(AIAlertTitlesNumericUpDown);
            AiFeaturesPanel.Controls.Add(AIAlertTitlesLabel);
            AiFeaturesPanel.Controls.Add(AIResourceLifeTimePeriodComboBox);
            AiFeaturesPanel.Controls.Add(AIResourceLifeTimeNumericUpDown);
            AiFeaturesPanel.Controls.Add(AiOpenAiResourceLifeTimeLabel);
            AiFeaturesPanel.Controls.Add(AiOpenAiApiTokenLabel);
            AiFeaturesPanel.Controls.Add(AiOpenAiApiTokenTextBox);
            AiFeaturesPanel.Enabled = false;
            AiFeaturesPanel.Location = new Point(0, 162);
            AiFeaturesPanel.Name = "AiFeaturesPanel";
            AiFeaturesPanel.Size = new Size(480, 313);
            AiFeaturesPanel.TabIndex = 5;
            // 
            // AIAlertAudioNumericUpDown
            // 
            AIAlertAudioNumericUpDown.Location = new Point(20, 271);
            AIAlertAudioNumericUpDown.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            AIAlertAudioNumericUpDown.Name = "AIAlertAudioNumericUpDown";
            AIAlertAudioNumericUpDown.Size = new Size(457, 23);
            AIAlertAudioNumericUpDown.TabIndex = 21;
            AIAlertAudioNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AIAlertAudioLabel
            // 
            AIAlertAudioLabel.AutoSize = true;
            AIAlertAudioLabel.Location = new Point(20, 253);
            AIAlertAudioLabel.Name = "AIAlertAudioLabel";
            AIAlertAudioLabel.Size = new Size(67, 15);
            AIAlertAudioLabel.TabIndex = 20;
            AIAlertAudioLabel.Text = "Alert Audio";
            // 
            // AIAlertImagesNumericUpDown
            // 
            AIAlertImagesNumericUpDown.Location = new Point(20, 227);
            AIAlertImagesNumericUpDown.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            AIAlertImagesNumericUpDown.Name = "AIAlertImagesNumericUpDown";
            AIAlertImagesNumericUpDown.Size = new Size(457, 23);
            AIAlertImagesNumericUpDown.TabIndex = 19;
            AIAlertImagesNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AIAlertImagesLabel
            // 
            AIAlertImagesLabel.AutoSize = true;
            AIAlertImagesLabel.Location = new Point(20, 209);
            AIAlertImagesLabel.Name = "AIAlertImagesLabel";
            AIAlertImagesLabel.Size = new Size(73, 15);
            AIAlertImagesLabel.TabIndex = 18;
            AIAlertImagesLabel.Text = "Alert Images";
            // 
            // AIAlertMessagesNumericUpDown
            // 
            AIAlertMessagesNumericUpDown.Location = new Point(20, 183);
            AIAlertMessagesNumericUpDown.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            AIAlertMessagesNumericUpDown.Name = "AIAlertMessagesNumericUpDown";
            AIAlertMessagesNumericUpDown.Size = new Size(457, 23);
            AIAlertMessagesNumericUpDown.TabIndex = 17;
            AIAlertMessagesNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AIAlertMessagesLabel
            // 
            AIAlertMessagesLabel.AutoSize = true;
            AIAlertMessagesLabel.Location = new Point(20, 165);
            AIAlertMessagesLabel.Name = "AIAlertMessagesLabel";
            AIAlertMessagesLabel.Size = new Size(86, 15);
            AIAlertMessagesLabel.TabIndex = 16;
            AIAlertMessagesLabel.Text = "Alert Messages";
            // 
            // AICachedResourceLimitsLabel
            // 
            AICachedResourceLimitsLabel.AutoSize = true;
            AICachedResourceLimitsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AICachedResourceLimitsLabel.Location = new Point(20, 106);
            AICachedResourceLimitsLabel.Name = "AICachedResourceLimitsLabel";
            AICachedResourceLimitsLabel.Size = new Size(291, 15);
            AICachedResourceLimitsLabel.TabIndex = 15;
            AICachedResourceLimitsLabel.Text = "Cached Resource Limits (Per Configured Reminder)";
            // 
            // AIAlertTitlesNumericUpDown
            // 
            AIAlertTitlesNumericUpDown.Location = new Point(20, 139);
            AIAlertTitlesNumericUpDown.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            AIAlertTitlesNumericUpDown.Name = "AIAlertTitlesNumericUpDown";
            AIAlertTitlesNumericUpDown.Size = new Size(457, 23);
            AIAlertTitlesNumericUpDown.TabIndex = 14;
            AIAlertTitlesNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AIAlertTitlesLabel
            // 
            AIAlertTitlesLabel.AutoSize = true;
            AIAlertTitlesLabel.Location = new Point(20, 121);
            AIAlertTitlesLabel.Name = "AIAlertTitlesLabel";
            AIAlertTitlesLabel.Size = new Size(62, 15);
            AIAlertTitlesLabel.TabIndex = 13;
            AIAlertTitlesLabel.Text = "Alert Titles";
            // 
            // AIResourceLifeTimePeriodComboBox
            // 
            AIResourceLifeTimePeriodComboBox.FormattingEnabled = true;
            AIResourceLifeTimePeriodComboBox.Location = new Point(312, 74);
            AIResourceLifeTimePeriodComboBox.Name = "AIResourceLifeTimePeriodComboBox";
            AIResourceLifeTimePeriodComboBox.Size = new Size(165, 23);
            AIResourceLifeTimePeriodComboBox.TabIndex = 9;
            // 
            // AIResourceLifeTimeNumericUpDown
            // 
            AIResourceLifeTimeNumericUpDown.Location = new Point(20, 74);
            AIResourceLifeTimeNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            AIResourceLifeTimeNumericUpDown.Name = "AIResourceLifeTimeNumericUpDown";
            AIResourceLifeTimeNumericUpDown.Size = new Size(286, 23);
            AIResourceLifeTimeNumericUpDown.TabIndex = 8;
            AIResourceLifeTimeNumericUpDown.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // AiOpenAiResourceLifeTimeLabel
            // 
            AiOpenAiResourceLifeTimeLabel.AutoSize = true;
            AiOpenAiResourceLifeTimeLabel.Location = new Point(20, 56);
            AiOpenAiResourceLifeTimeLabel.Name = "AiOpenAiResourceLifeTimeLabel";
            AiOpenAiResourceLifeTimeLabel.Size = new Size(101, 15);
            AiOpenAiResourceLifeTimeLabel.TabIndex = 7;
            AiOpenAiResourceLifeTimeLabel.Text = "Resource Lifetime";
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
            AiOpenAiApiTokenTextBox.Location = new Point(20, 30);
            AiOpenAiApiTokenTextBox.Name = "AiOpenAiApiTokenTextBox";
            AiOpenAiApiTokenTextBox.Size = new Size(457, 23);
            AiOpenAiApiTokenTextBox.TabIndex = 5;
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
            TopPanel.Size = new Size(496, 517);
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
            BottomPanel.Location = new Point(0, 517);
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
            // SettingsForm
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 563);
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
            AIAlertPanel.ResumeLayout(false);
            AiFeaturesPanel.ResumeLayout(false);
            AiFeaturesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AIAlertAudioNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AIAlertImagesNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AIAlertMessagesNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AIAlertTitlesNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AIResourceLifeTimeNumericUpDown).EndInit();
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
        private ComboBox AIResourceLifeTimePeriodComboBox;
        private NumericUpDown AIResourceLifeTimeNumericUpDown;
        private Label AiOpenAiResourceLifeTimeLabel;
        private NumericUpDown AIAlertAudioNumericUpDown;
        private Label AIAlertAudioLabel;
        private NumericUpDown AIAlertImagesNumericUpDown;
        private Label AIAlertImagesLabel;
        private NumericUpDown AIAlertMessagesNumericUpDown;
        private Label AIAlertMessagesLabel;
        private Label AICachedResourceLimitsLabel;
        private NumericUpDown AIAlertTitlesNumericUpDown;
        private Label AIAlertTitlesLabel;
        private Panel AIAlertPanel;
    }
}
