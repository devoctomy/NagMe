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
            CnclButton = new Button();
            TopPanel = new Panel();
            ReminderEditorTabs = new TabControl();
            GeneralTab = new TabPage();
            GeneralDescriptionTextBox = new TextBox();
            GeneralDescriptionLabel = new Label();
            GeneralNameTextBox = new TextBox();
            GeneralNameLabel = new Label();
            TimingsTab = new TabPage();
            TimingsIntervalPeriodComboBox = new ComboBox();
            TimingsIntervalNumericUpDown = new NumericUpDown();
            label1 = new Label();
            NotificationTab = new TabPage();
            NotificationSettingsTabs = new TabControl();
            NotificationMessageBoxTab = new TabPage();
            NotificationToastTab = new TabPage();
            NotificationFullScreenTab = new TabPage();
            NotificationFullScreenDisplayTimePeriodComboBox = new ComboBox();
            NotificationFullScreenDisplayTimeNumericUpDown = new NumericUpDown();
            NotificationFullScreenDisplayTimeLabel = new Label();
            NotificationFullScreenBackgroundOpacityTrackbar = new TrackBar();
            NotificationFullScreenBackgroundOpacityLabel = new Label();
            NotificationTypeLabel = new Label();
            NotificationTypeComboBox = new ComboBox();
            AiTab = new TabPage();
            panel1 = new Panel();
            label2 = new Label();
            AIEnabledCheckBox = new CheckBox();
            BottomPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            ReminderEditorTabs.SuspendLayout();
            GeneralTab.SuspendLayout();
            TimingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TimingsIntervalNumericUpDown).BeginInit();
            NotificationTab.SuspendLayout();
            NotificationSettingsTabs.SuspendLayout();
            NotificationFullScreenTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationFullScreenDisplayTimeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotificationFullScreenBackgroundOpacityTrackbar).BeginInit();
            AiTab.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(OkButton);
            BottomPanel.Controls.Add(CnclButton);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 401);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(521, 46);
            BottomPanel.TabIndex = 4;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkButton.Location = new Point(321, 7);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(91, 27);
            OkButton.TabIndex = 7;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // CnclButton
            // 
            CnclButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CnclButton.DialogResult = DialogResult.Cancel;
            CnclButton.Location = new Point(418, 7);
            CnclButton.Name = "CnclButton";
            CnclButton.Size = new Size(91, 27);
            CnclButton.TabIndex = 6;
            CnclButton.Text = "Cancel";
            CnclButton.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(ReminderEditorTabs);
            TopPanel.Dock = DockStyle.Fill;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(521, 401);
            TopPanel.TabIndex = 5;
            // 
            // ReminderEditorTabs
            // 
            ReminderEditorTabs.Controls.Add(GeneralTab);
            ReminderEditorTabs.Controls.Add(TimingsTab);
            ReminderEditorTabs.Controls.Add(NotificationTab);
            ReminderEditorTabs.Controls.Add(AiTab);
            ReminderEditorTabs.Dock = DockStyle.Fill;
            ReminderEditorTabs.Location = new Point(0, 0);
            ReminderEditorTabs.Name = "ReminderEditorTabs";
            ReminderEditorTabs.SelectedIndex = 0;
            ReminderEditorTabs.Size = new Size(521, 401);
            ReminderEditorTabs.TabIndex = 0;
            // 
            // GeneralTab
            // 
            GeneralTab.Controls.Add(GeneralDescriptionTextBox);
            GeneralTab.Controls.Add(GeneralDescriptionLabel);
            GeneralTab.Controls.Add(GeneralNameTextBox);
            GeneralTab.Controls.Add(GeneralNameLabel);
            GeneralTab.Location = new Point(4, 24);
            GeneralTab.Name = "GeneralTab";
            GeneralTab.Padding = new Padding(3);
            GeneralTab.Size = new Size(513, 373);
            GeneralTab.TabIndex = 2;
            GeneralTab.Text = "General";
            GeneralTab.UseVisualStyleBackColor = true;
            // 
            // GeneralDescriptionTextBox
            // 
            GeneralDescriptionTextBox.Location = new Point(17, 87);
            GeneralDescriptionTextBox.Multiline = true;
            GeneralDescriptionTextBox.Name = "GeneralDescriptionTextBox";
            GeneralDescriptionTextBox.ScrollBars = ScrollBars.Vertical;
            GeneralDescriptionTextBox.Size = new Size(475, 149);
            GeneralDescriptionTextBox.TabIndex = 4;
            // 
            // GeneralDescriptionLabel
            // 
            GeneralDescriptionLabel.AutoSize = true;
            GeneralDescriptionLabel.Location = new Point(17, 69);
            GeneralDescriptionLabel.Name = "GeneralDescriptionLabel";
            GeneralDescriptionLabel.Size = new Size(67, 15);
            GeneralDescriptionLabel.TabIndex = 3;
            GeneralDescriptionLabel.Text = "Description";
            // 
            // GeneralNameTextBox
            // 
            GeneralNameTextBox.Location = new Point(17, 31);
            GeneralNameTextBox.Name = "GeneralNameTextBox";
            GeneralNameTextBox.Size = new Size(475, 23);
            GeneralNameTextBox.TabIndex = 2;
            // 
            // GeneralNameLabel
            // 
            GeneralNameLabel.AutoSize = true;
            GeneralNameLabel.Location = new Point(17, 13);
            GeneralNameLabel.Name = "GeneralNameLabel";
            GeneralNameLabel.Size = new Size(39, 15);
            GeneralNameLabel.TabIndex = 1;
            GeneralNameLabel.Text = "Name";
            // 
            // TimingsTab
            // 
            TimingsTab.Controls.Add(TimingsIntervalPeriodComboBox);
            TimingsTab.Controls.Add(TimingsIntervalNumericUpDown);
            TimingsTab.Controls.Add(label1);
            TimingsTab.Location = new Point(4, 24);
            TimingsTab.Name = "TimingsTab";
            TimingsTab.Padding = new Padding(3);
            TimingsTab.Size = new Size(513, 373);
            TimingsTab.TabIndex = 0;
            TimingsTab.Text = "Timings";
            TimingsTab.UseVisualStyleBackColor = true;
            // 
            // TimingsIntervalPeriodComboBox
            // 
            TimingsIntervalPeriodComboBox.FormattingEnabled = true;
            TimingsIntervalPeriodComboBox.Location = new Point(328, 31);
            TimingsIntervalPeriodComboBox.Name = "TimingsIntervalPeriodComboBox";
            TimingsIntervalPeriodComboBox.Size = new Size(165, 23);
            TimingsIntervalPeriodComboBox.TabIndex = 4;
            // 
            // TimingsIntervalNumericUpDown
            // 
            TimingsIntervalNumericUpDown.Location = new Point(17, 31);
            TimingsIntervalNumericUpDown.Maximum = new decimal(new int[] { 86400, 0, 0, 0 });
            TimingsIntervalNumericUpDown.Name = "TimingsIntervalNumericUpDown";
            TimingsIntervalNumericUpDown.Size = new Size(305, 23);
            TimingsIntervalNumericUpDown.TabIndex = 3;
            TimingsIntervalNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Interval";
            // 
            // NotificationTab
            // 
            NotificationTab.Controls.Add(NotificationSettingsTabs);
            NotificationTab.Controls.Add(NotificationTypeLabel);
            NotificationTab.Controls.Add(NotificationTypeComboBox);
            NotificationTab.Location = new Point(4, 24);
            NotificationTab.Name = "NotificationTab";
            NotificationTab.Size = new Size(513, 373);
            NotificationTab.TabIndex = 3;
            NotificationTab.Text = "Notification";
            NotificationTab.UseVisualStyleBackColor = true;
            // 
            // NotificationSettingsTabs
            // 
            NotificationSettingsTabs.Controls.Add(NotificationMessageBoxTab);
            NotificationSettingsTabs.Controls.Add(NotificationToastTab);
            NotificationSettingsTabs.Controls.Add(NotificationFullScreenTab);
            NotificationSettingsTabs.Location = new Point(17, 60);
            NotificationSettingsTabs.Name = "NotificationSettingsTabs";
            NotificationSettingsTabs.SelectedIndex = 0;
            NotificationSettingsTabs.Size = new Size(493, 310);
            NotificationSettingsTabs.TabIndex = 4;
            // 
            // NotificationMessageBoxTab
            // 
            NotificationMessageBoxTab.Location = new Point(4, 24);
            NotificationMessageBoxTab.Name = "NotificationMessageBoxTab";
            NotificationMessageBoxTab.Padding = new Padding(3);
            NotificationMessageBoxTab.Size = new Size(485, 282);
            NotificationMessageBoxTab.TabIndex = 0;
            NotificationMessageBoxTab.Text = "MessageBox";
            NotificationMessageBoxTab.UseVisualStyleBackColor = true;
            // 
            // NotificationToastTab
            // 
            NotificationToastTab.Location = new Point(4, 24);
            NotificationToastTab.Name = "NotificationToastTab";
            NotificationToastTab.Padding = new Padding(3);
            NotificationToastTab.Size = new Size(485, 282);
            NotificationToastTab.TabIndex = 1;
            NotificationToastTab.Text = "Toast";
            NotificationToastTab.UseVisualStyleBackColor = true;
            // 
            // NotificationFullScreenTab
            // 
            NotificationFullScreenTab.Controls.Add(NotificationFullScreenDisplayTimePeriodComboBox);
            NotificationFullScreenTab.Controls.Add(NotificationFullScreenDisplayTimeNumericUpDown);
            NotificationFullScreenTab.Controls.Add(NotificationFullScreenDisplayTimeLabel);
            NotificationFullScreenTab.Controls.Add(NotificationFullScreenBackgroundOpacityTrackbar);
            NotificationFullScreenTab.Controls.Add(NotificationFullScreenBackgroundOpacityLabel);
            NotificationFullScreenTab.Location = new Point(4, 24);
            NotificationFullScreenTab.Name = "NotificationFullScreenTab";
            NotificationFullScreenTab.Size = new Size(485, 282);
            NotificationFullScreenTab.TabIndex = 2;
            NotificationFullScreenTab.Text = "FullScreen";
            NotificationFullScreenTab.UseVisualStyleBackColor = true;
            // 
            // NotificationFullScreenDisplayTimePeriodComboBox
            // 
            NotificationFullScreenDisplayTimePeriodComboBox.FormattingEnabled = true;
            NotificationFullScreenDisplayTimePeriodComboBox.Location = new Point(304, 94);
            NotificationFullScreenDisplayTimePeriodComboBox.Name = "NotificationFullScreenDisplayTimePeriodComboBox";
            NotificationFullScreenDisplayTimePeriodComboBox.Size = new Size(165, 23);
            NotificationFullScreenDisplayTimePeriodComboBox.TabIndex = 8;
            // 
            // NotificationFullScreenDisplayTimeNumericUpDown
            // 
            NotificationFullScreenDisplayTimeNumericUpDown.Location = new Point(14, 95);
            NotificationFullScreenDisplayTimeNumericUpDown.Maximum = new decimal(new int[] { 86400, 0, 0, 0 });
            NotificationFullScreenDisplayTimeNumericUpDown.Name = "NotificationFullScreenDisplayTimeNumericUpDown";
            NotificationFullScreenDisplayTimeNumericUpDown.Size = new Size(284, 23);
            NotificationFullScreenDisplayTimeNumericUpDown.TabIndex = 7;
            NotificationFullScreenDisplayTimeNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // NotificationFullScreenDisplayTimeLabel
            // 
            NotificationFullScreenDisplayTimeLabel.AutoSize = true;
            NotificationFullScreenDisplayTimeLabel.Location = new Point(14, 77);
            NotificationFullScreenDisplayTimeLabel.Name = "NotificationFullScreenDisplayTimeLabel";
            NotificationFullScreenDisplayTimeLabel.Size = new Size(74, 15);
            NotificationFullScreenDisplayTimeLabel.TabIndex = 6;
            NotificationFullScreenDisplayTimeLabel.Text = "Display Time";
            // 
            // NotificationFullScreenBackgroundOpacityTrackbar
            // 
            NotificationFullScreenBackgroundOpacityTrackbar.Location = new Point(14, 29);
            NotificationFullScreenBackgroundOpacityTrackbar.Maximum = 100;
            NotificationFullScreenBackgroundOpacityTrackbar.Name = "NotificationFullScreenBackgroundOpacityTrackbar";
            NotificationFullScreenBackgroundOpacityTrackbar.Size = new Size(455, 45);
            NotificationFullScreenBackgroundOpacityTrackbar.TabIndex = 5;
            NotificationFullScreenBackgroundOpacityTrackbar.TickFrequency = 10;
            // 
            // NotificationFullScreenBackgroundOpacityLabel
            // 
            NotificationFullScreenBackgroundOpacityLabel.AutoSize = true;
            NotificationFullScreenBackgroundOpacityLabel.Location = new Point(14, 11);
            NotificationFullScreenBackgroundOpacityLabel.Name = "NotificationFullScreenBackgroundOpacityLabel";
            NotificationFullScreenBackgroundOpacityLabel.Size = new Size(115, 15);
            NotificationFullScreenBackgroundOpacityLabel.TabIndex = 4;
            NotificationFullScreenBackgroundOpacityLabel.Text = "Background Opacity";
            // 
            // NotificationTypeLabel
            // 
            NotificationTypeLabel.AutoSize = true;
            NotificationTypeLabel.Location = new Point(17, 13);
            NotificationTypeLabel.Name = "NotificationTypeLabel";
            NotificationTypeLabel.Size = new Size(31, 15);
            NotificationTypeLabel.TabIndex = 3;
            NotificationTypeLabel.Text = "Type";
            // 
            // NotificationTypeComboBox
            // 
            NotificationTypeComboBox.FormattingEnabled = true;
            NotificationTypeComboBox.Location = new Point(17, 31);
            NotificationTypeComboBox.Name = "NotificationTypeComboBox";
            NotificationTypeComboBox.Size = new Size(488, 23);
            NotificationTypeComboBox.TabIndex = 0;
            // 
            // AiTab
            // 
            AiTab.Controls.Add(AIEnabledCheckBox);
            AiTab.Controls.Add(panel1);
            AiTab.Location = new Point(4, 24);
            AiTab.Name = "AiTab";
            AiTab.Padding = new Padding(3);
            AiTab.Size = new Size(513, 373);
            AiTab.TabIndex = 1;
            AiTab.Text = "AI";
            AiTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(8, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 54);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(473, 38);
            label2.TabIndex = 0;
            label2.Text = "AI Functionality currently only works with FullScreen notifications, and as such enabling this feature will force FullScreen notifications.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AIEnabledCheckBox
            // 
            AIEnabledCheckBox.AutoSize = true;
            AIEnabledCheckBox.Location = new Point(8, 66);
            AIEnabledCheckBox.Name = "AIEnabledCheckBox";
            AIEnabledCheckBox.Size = new Size(61, 19);
            AIEnabledCheckBox.TabIndex = 1;
            AIEnabledCheckBox.Text = "Enable";
            AIEnabledCheckBox.UseVisualStyleBackColor = true;
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
            StartPosition = FormStartPosition.CenterParent;
            Text = "NagMe - Reminder Editor";
            BottomPanel.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            ReminderEditorTabs.ResumeLayout(false);
            GeneralTab.ResumeLayout(false);
            GeneralTab.PerformLayout();
            TimingsTab.ResumeLayout(false);
            TimingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TimingsIntervalNumericUpDown).EndInit();
            NotificationTab.ResumeLayout(false);
            NotificationTab.PerformLayout();
            NotificationSettingsTabs.ResumeLayout(false);
            NotificationFullScreenTab.ResumeLayout(false);
            NotificationFullScreenTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationFullScreenDisplayTimeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotificationFullScreenBackgroundOpacityTrackbar).EndInit();
            AiTab.ResumeLayout(false);
            AiTab.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BottomPanel;
        private Button OkButton;
        private Button CnclButton;
        private Panel TopPanel;
        private TabControl ReminderEditorTabs;
        private TabPage TimingsTab;
        private TabPage AiTab;
        private TabPage GeneralTab;
        private Label GeneralNameLabel;
        private TextBox GeneralNameTextBox;
        private TextBox GeneralDescriptionTextBox;
        private Label GeneralDescriptionLabel;
        private Label label1;
        private ComboBox TimingsIntervalPeriodComboBox;
        private NumericUpDown TimingsIntervalNumericUpDown;
        private TabPage NotificationTab;
        private Label NotificationTypeLabel;
        private ComboBox NotificationTypeComboBox;
        private TabControl NotificationSettingsTabs;
        private TabPage NotificationMessageBoxTab;
        private TabPage NotificationToastTab;
        private TabPage NotificationFullScreenTab;
        private TrackBar NotificationFullScreenBackgroundOpacityTrackbar;
        private Label NotificationFullScreenBackgroundOpacityLabel;
        private ComboBox NotificationFullScreenDisplayTimePeriodComboBox;
        private NumericUpDown NotificationFullScreenDisplayTimeNumericUpDown;
        private Label NotificationFullScreenDisplayTimeLabel;
        private Panel panel1;
        private Label label2;
        private CheckBox AIEnabledCheckBox;
    }
}