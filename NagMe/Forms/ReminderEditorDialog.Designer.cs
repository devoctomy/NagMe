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
            ReminderEditorTabs = new TabControl();
            GenerallTab = new TabPage();
            GeneralDescriptionTextBox = new TextBox();
            GeneralDescriptionLabel = new Label();
            GeneralNameTextBox = new TextBox();
            GeneralNameLabel = new Label();
            TimingsTab = new TabPage();
            TimingsIntervalPeriod = new ComboBox();
            TimingsIntervalNumericUpDown = new NumericUpDown();
            label1 = new Label();
            AiTab = new TabPage();
            BottomPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            ReminderEditorTabs.SuspendLayout();
            GenerallTab.SuspendLayout();
            TimingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TimingsIntervalNumericUpDown).BeginInit();
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
            TopPanel.Controls.Add(ReminderEditorTabs);
            TopPanel.Dock = DockStyle.Fill;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(521, 401);
            TopPanel.TabIndex = 5;
            // 
            // ReminderEditorTabs
            // 
            ReminderEditorTabs.Controls.Add(GenerallTab);
            ReminderEditorTabs.Controls.Add(TimingsTab);
            ReminderEditorTabs.Controls.Add(AiTab);
            ReminderEditorTabs.Dock = DockStyle.Fill;
            ReminderEditorTabs.Location = new Point(0, 0);
            ReminderEditorTabs.Name = "ReminderEditorTabs";
            ReminderEditorTabs.SelectedIndex = 0;
            ReminderEditorTabs.Size = new Size(521, 401);
            ReminderEditorTabs.TabIndex = 0;
            // 
            // GenerallTab
            // 
            GenerallTab.Controls.Add(GeneralDescriptionTextBox);
            GenerallTab.Controls.Add(GeneralDescriptionLabel);
            GenerallTab.Controls.Add(GeneralNameTextBox);
            GenerallTab.Controls.Add(GeneralNameLabel);
            GenerallTab.Location = new Point(4, 24);
            GenerallTab.Name = "GenerallTab";
            GenerallTab.Padding = new Padding(3);
            GenerallTab.Size = new Size(513, 373);
            GenerallTab.TabIndex = 2;
            GenerallTab.Text = "General";
            GenerallTab.UseVisualStyleBackColor = true;
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
            TimingsTab.Controls.Add(TimingsIntervalPeriod);
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
            // TimingsIntervalPeriod
            // 
            TimingsIntervalPeriod.FormattingEnabled = true;
            TimingsIntervalPeriod.Location = new Point(328, 31);
            TimingsIntervalPeriod.Name = "TimingsIntervalPeriod";
            TimingsIntervalPeriod.Size = new Size(165, 23);
            TimingsIntervalPeriod.TabIndex = 4;
            TimingsIntervalPeriod.SelectedIndexChanged += TimingsIntervalPeriod_SelectedIndexChanged;
            // 
            // TimingsIntervalNumericUpDown
            // 
            TimingsIntervalNumericUpDown.Location = new Point(17, 31);
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
            // AiTab
            // 
            AiTab.Location = new Point(4, 24);
            AiTab.Name = "AiTab";
            AiTab.Padding = new Padding(3);
            AiTab.Size = new Size(513, 373);
            AiTab.TabIndex = 1;
            AiTab.Text = "AI";
            AiTab.UseVisualStyleBackColor = true;
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
            ReminderEditorTabs.ResumeLayout(false);
            GenerallTab.ResumeLayout(false);
            GenerallTab.PerformLayout();
            TimingsTab.ResumeLayout(false);
            TimingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TimingsIntervalNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BottomPanel;
        private Button OkButton;
        private Button CancelButton;
        private Button ApplyButton;
        private Panel TopPanel;
        private TabControl ReminderEditorTabs;
        private TabPage TimingsTab;
        private TabPage AiTab;
        private Button button1;
        private Button button2;
        private TabPage GenerallTab;
        private Label GeneralNameLabel;
        private TextBox GeneralNameTextBox;
        private TextBox GeneralDescriptionTextBox;
        private Label GeneralDescriptionLabel;
        private Label label1;
        private ComboBox TimingsIntervalPeriod;
        private NumericUpDown TimingsIntervalNumericUpDown;
    }
}