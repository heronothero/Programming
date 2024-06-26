namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enumTab = new System.Windows.Forms.TabControl();
            this.EnumPage1 = new System.Windows.Forms.TabPage();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.EnumListBoxLabel = new System.Windows.Forms.Label();
            this.EnumListValues = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputValue = new System.Windows.Forms.TextBox();
            this.IntVale = new System.Windows.Forms.Label();
            this.WeekdayBox = new System.Windows.Forms.GroupBox();
            this.WeekdayInput = new System.Windows.Forms.TextBox();
            this.ValueParseLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SeasonBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.enumTab.SuspendLayout();
            this.EnumPage1.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.WeekdayBox.SuspendLayout();
            this.SeasonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enumTab
            // 
            this.enumTab.Controls.Add(this.EnumPage1);
            this.enumTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumTab.Location = new System.Drawing.Point(0, 0);
            this.enumTab.Name = "enumTab";
            this.enumTab.SelectedIndex = 0;
            this.enumTab.Size = new System.Drawing.Size(800, 450);
            this.enumTab.TabIndex = 0;
            // 
            // EnumPage1
            // 
            this.EnumPage1.Controls.Add(this.SeasonBox);
            this.EnumPage1.Controls.Add(this.WeekdayBox);
            this.EnumPage1.Controls.Add(this.EnumGroupBox);
            this.EnumPage1.Location = new System.Drawing.Point(4, 22);
            this.EnumPage1.Name = "EnumPage1";
            this.EnumPage1.Padding = new System.Windows.Forms.Padding(3);
            this.EnumPage1.Size = new System.Drawing.Size(792, 424);
            this.EnumPage1.TabIndex = 0;
            this.EnumPage1.Text = "Enum";
            this.EnumPage1.UseVisualStyleBackColor = true;
            this.EnumPage1.Click += new System.EventHandler(this.EnumPage1_Click);
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.IntVale);
            this.EnumGroupBox.Controls.Add(this.InputValue);
            this.EnumGroupBox.Controls.Add(this.label1);
            this.EnumGroupBox.Controls.Add(this.EnumListValues);
            this.EnumGroupBox.Controls.Add(this.EnumListBoxLabel);
            this.EnumGroupBox.Controls.Add(this.EnumListBox);
            this.EnumGroupBox.Location = new System.Drawing.Point(6, 3);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Size = new System.Drawing.Size(778, 286);
            this.EnumGroupBox.TabIndex = 0;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            // 
            // EnumListBox
            // 
            this.EnumListBox.FormattingEnabled = true;
            this.EnumListBox.Location = new System.Drawing.Point(8, 37);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.ScrollAlwaysVisible = true;
            this.EnumListBox.Size = new System.Drawing.Size(162, 225);
            this.EnumListBox.TabIndex = 1;
            this.EnumListBox.SelectedIndexChanged += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // EnumListBoxLabel
            // 
            this.EnumListBoxLabel.AutoSize = true;
            this.EnumListBoxLabel.Location = new System.Drawing.Point(6, 21);
            this.EnumListBoxLabel.Name = "EnumListBoxLabel";
            this.EnumListBoxLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumListBoxLabel.TabIndex = 2;
            this.EnumListBoxLabel.Text = "Choose enumeration:";
            // 
            // EnumListValues
            // 
            this.EnumListValues.FormattingEnabled = true;
            this.EnumListValues.Location = new System.Drawing.Point(186, 37);
            this.EnumListValues.Name = "EnumListValues";
            this.EnumListValues.ScrollAlwaysVisible = true;
            this.EnumListValues.Size = new System.Drawing.Size(162, 225);
            this.EnumListValues.TabIndex = 3;
            this.EnumListValues.SelectedIndexChanged += new System.EventHandler(this.EnumListValues_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose value:";
            // 
            // InputValue
            // 
            this.InputValue.Location = new System.Drawing.Point(363, 37);
            this.InputValue.Name = "InputValue";
            this.InputValue.Size = new System.Drawing.Size(150, 20);
            this.InputValue.TabIndex = 5;
            this.InputValue.TextChanged += new System.EventHandler(this.InputValue_TextChanged);
            // 
            // IntVale
            // 
            this.IntVale.AutoSize = true;
            this.IntVale.Location = new System.Drawing.Point(360, 21);
            this.IntVale.Name = "IntVale";
            this.IntVale.Size = new System.Drawing.Size(51, 13);
            this.IntVale.TabIndex = 6;
            this.IntVale.Text = "Int value:";
            // 
            // WeekdayBox
            // 
            this.WeekdayBox.Controls.Add(this.ResultLabel);
            this.WeekdayBox.Controls.Add(this.ParseButton);
            this.WeekdayBox.Controls.Add(this.ValueParseLabel);
            this.WeekdayBox.Controls.Add(this.WeekdayInput);
            this.WeekdayBox.Location = new System.Drawing.Point(8, 295);
            this.WeekdayBox.Name = "WeekdayBox";
            this.WeekdayBox.Size = new System.Drawing.Size(346, 123);
            this.WeekdayBox.TabIndex = 7;
            this.WeekdayBox.TabStop = false;
            this.WeekdayBox.Text = "Weekday Parsing";
            // 
            // WeekdayInput
            // 
            this.WeekdayInput.Location = new System.Drawing.Point(6, 41);
            this.WeekdayInput.Name = "WeekdayInput";
            this.WeekdayInput.Size = new System.Drawing.Size(200, 20);
            this.WeekdayInput.TabIndex = 8;
            this.WeekdayInput.TextChanged += new System.EventHandler(this.WeekdayInput_TextChanged);
            // 
            // ValueParseLabel
            // 
            this.ValueParseLabel.AutoSize = true;
            this.ValueParseLabel.Location = new System.Drawing.Point(4, 25);
            this.ValueParseLabel.Name = "ValueParseLabel";
            this.ValueParseLabel.Size = new System.Drawing.Size(115, 13);
            this.ValueParseLabel.TabIndex = 9;
            this.ValueParseLabel.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(212, 39);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 8;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(6, 68);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // SeasonBox
            // 
            this.SeasonBox.Controls.Add(this.SeasonButton);
            this.SeasonBox.Controls.Add(this.SeasonLabel);
            this.SeasonBox.Controls.Add(this.SeasonComboBox);
            this.SeasonBox.Location = new System.Drawing.Point(360, 295);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(424, 123);
            this.SeasonBox.TabIndex = 8;
            this.SeasonBox.TabStop = false;
            this.SeasonBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(9, 41);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(200, 21);
            this.SeasonComboBox.TabIndex = 7;
            this.SeasonComboBox.SelectedIndexChanged += new System.EventHandler(this.SeasonComboBox_SelectedIndexChanged);
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(6, 25);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonLabel.TabIndex = 8;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(215, 40);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonButton.TabIndex = 9;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enumTab);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.enumTab.ResumeLayout(false);
            this.EnumPage1.ResumeLayout(false);
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.WeekdayBox.ResumeLayout(false);
            this.WeekdayBox.PerformLayout();
            this.SeasonBox.ResumeLayout(false);
            this.SeasonBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl enumTab;
        private System.Windows.Forms.TabPage EnumPage1;
        private System.Windows.Forms.GroupBox EnumGroupBox;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EnumListValues;
        private System.Windows.Forms.Label EnumListBoxLabel;
        private System.Windows.Forms.Label IntVale;
        private System.Windows.Forms.TextBox InputValue;
        private System.Windows.Forms.GroupBox WeekdayBox;
        private System.Windows.Forms.TextBox WeekdayInput;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label ValueParseLabel;
        private System.Windows.Forms.GroupBox SeasonBox;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.Label SeasonLabel;
    }
}

