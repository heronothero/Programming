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
            this.SeasonBox = new System.Windows.Forms.GroupBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.WeekdayBox = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ValueParseLabel = new System.Windows.Forms.Label();
            this.WeekdayInput = new System.Windows.Forms.TextBox();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.IntVale = new System.Windows.Forms.Label();
            this.InputValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnumListValues = new System.Windows.Forms.ListBox();
            this.EnumListBoxLabel = new System.Windows.Forms.Label();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.ClassesGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorInput = new System.Windows.Forms.TextBox();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.LengthInput = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.MovieTimeInput = new System.Windows.Forms.TextBox();
            this.ReleaseYearInput = new System.Windows.Forms.TextBox();
            this.GenreInput = new System.Windows.Forms.TextBox();
            this.RatingInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MovieTimeLabel = new System.Windows.Forms.Label();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.FindFilmButton = new System.Windows.Forms.Button();
            this.enumTab.SuspendLayout();
            this.EnumPage1.SuspendLayout();
            this.SeasonBox.SuspendLayout();
            this.WeekdayBox.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.ClassesGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enumTab
            // 
            this.enumTab.Controls.Add(this.EnumPage1);
            this.enumTab.Controls.Add(this.ClassesTabPage);
            this.enumTab.Controls.Add(this.tabPage1);
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
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(6, 25);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonLabel.TabIndex = 8;
            this.SeasonLabel.Text = "Choose season:";
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
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(6, 68);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
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
            // ValueParseLabel
            // 
            this.ValueParseLabel.AutoSize = true;
            this.ValueParseLabel.Location = new System.Drawing.Point(4, 25);
            this.ValueParseLabel.Name = "ValueParseLabel";
            this.ValueParseLabel.Size = new System.Drawing.Size(115, 13);
            this.ValueParseLabel.TabIndex = 9;
            this.ValueParseLabel.Text = "Type value for parsing:";
            // 
            // WeekdayInput
            // 
            this.WeekdayInput.Location = new System.Drawing.Point(6, 41);
            this.WeekdayInput.Name = "WeekdayInput";
            this.WeekdayInput.Size = new System.Drawing.Size(200, 20);
            this.WeekdayInput.TabIndex = 8;
            this.WeekdayInput.TextChanged += new System.EventHandler(this.WeekdayInput_TextChanged);
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
            // IntVale
            // 
            this.IntVale.AutoSize = true;
            this.IntVale.Location = new System.Drawing.Point(360, 21);
            this.IntVale.Name = "IntVale";
            this.IntVale.Size = new System.Drawing.Size(51, 13);
            this.IntVale.TabIndex = 6;
            this.IntVale.Text = "Int value:";
            // 
            // InputValue
            // 
            this.InputValue.Location = new System.Drawing.Point(363, 37);
            this.InputValue.Name = "InputValue";
            this.InputValue.Size = new System.Drawing.Size(150, 20);
            this.InputValue.TabIndex = 5;
            this.InputValue.TextChanged += new System.EventHandler(this.InputValue_TextChanged);
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
            // EnumListBoxLabel
            // 
            this.EnumListBoxLabel.AutoSize = true;
            this.EnumListBoxLabel.Location = new System.Drawing.Point(6, 21);
            this.EnumListBoxLabel.Name = "EnumListBoxLabel";
            this.EnumListBoxLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumListBoxLabel.TabIndex = 2;
            this.EnumListBoxLabel.Text = "Choose enumeration:";
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
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.ClassesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(792, 424);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesGroupBox
            // 
            this.ClassesGroupBox.Controls.Add(this.ColorLabel);
            this.ClassesGroupBox.Controls.Add(this.WidthLabel);
            this.ClassesGroupBox.Controls.Add(this.LengthLabel);
            this.ClassesGroupBox.Controls.Add(this.FindButton);
            this.ClassesGroupBox.Controls.Add(this.ColorInput);
            this.ClassesGroupBox.Controls.Add(this.WidthInput);
            this.ClassesGroupBox.Controls.Add(this.LengthInput);
            this.ClassesGroupBox.Controls.Add(this.RectanglesListBox);
            this.ClassesGroupBox.Location = new System.Drawing.Point(8, 3);
            this.ClassesGroupBox.Name = "ClassesGroupBox";
            this.ClassesGroupBox.Size = new System.Drawing.Size(384, 246);
            this.ClassesGroupBox.TabIndex = 0;
            this.ClassesGroupBox.TabStop = false;
            this.ClassesGroupBox.Text = "Rectangles";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(207, 105);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(207, 62);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 6;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(207, 19);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(43, 13);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Length:";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(210, 208);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 23);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ColorInput
            // 
            this.ColorInput.Location = new System.Drawing.Point(210, 121);
            this.ColorInput.Name = "ColorInput";
            this.ColorInput.Size = new System.Drawing.Size(100, 20);
            this.ColorInput.TabIndex = 4;
            this.ColorInput.TextChanged += new System.EventHandler(this.ColorInput_TextChanged);
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(210, 78);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(100, 20);
            this.WidthInput.TabIndex = 3;
            this.WidthInput.TextChanged += new System.EventHandler(this.WidthInput_TextChanged);
            // 
            // LengthInput
            // 
            this.LengthInput.Location = new System.Drawing.Point(210, 35);
            this.LengthInput.Name = "LengthInput";
            this.LengthInput.Size = new System.Drawing.Size(100, 20);
            this.LengthInput.TabIndex = 2;
            this.LengthInput.TextChanged += new System.EventHandler(this.LengthInput_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(14, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(161, 212);
            this.RectanglesListBox.TabIndex = 1;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MoviesGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Movies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.FindFilmButton);
            this.MoviesGroupBox.Controls.Add(this.RatingLabel);
            this.MoviesGroupBox.Controls.Add(this.GenreLabel);
            this.MoviesGroupBox.Controls.Add(this.ReleaseYearLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieTimeLabel);
            this.MoviesGroupBox.Controls.Add(this.NameLabel);
            this.MoviesGroupBox.Controls.Add(this.RatingInput);
            this.MoviesGroupBox.Controls.Add(this.GenreInput);
            this.MoviesGroupBox.Controls.Add(this.ReleaseYearInput);
            this.MoviesGroupBox.Controls.Add(this.MovieTimeInput);
            this.MoviesGroupBox.Controls.Add(this.NameInput);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Location = new System.Drawing.Point(8, 2);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(471, 254);
            this.MoviesGroupBox.TabIndex = 0;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Location = new System.Drawing.Point(6, 16);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(150, 225);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(181, 32);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(200, 20);
            this.NameInput.TabIndex = 1;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // MovieTimeInput
            // 
            this.MovieTimeInput.Location = new System.Drawing.Point(181, 71);
            this.MovieTimeInput.Name = "MovieTimeInput";
            this.MovieTimeInput.Size = new System.Drawing.Size(200, 20);
            this.MovieTimeInput.TabIndex = 2;
            this.MovieTimeInput.TextChanged += new System.EventHandler(this.MovieTimeInput_TextChanged);
            // 
            // ReleaseYearInput
            // 
            this.ReleaseYearInput.Location = new System.Drawing.Point(181, 110);
            this.ReleaseYearInput.Name = "ReleaseYearInput";
            this.ReleaseYearInput.Size = new System.Drawing.Size(200, 20);
            this.ReleaseYearInput.TabIndex = 3;
            this.ReleaseYearInput.TextChanged += new System.EventHandler(this.ReleaseYearInput_TextChanged);
            // 
            // GenreInput
            // 
            this.GenreInput.Location = new System.Drawing.Point(181, 149);
            this.GenreInput.Name = "GenreInput";
            this.GenreInput.Size = new System.Drawing.Size(200, 20);
            this.GenreInput.TabIndex = 4;
            this.GenreInput.TextChanged += new System.EventHandler(this.GenreInput_TextChanged);
            // 
            // RatingInput
            // 
            this.RatingInput.Location = new System.Drawing.Point(181, 188);
            this.RatingInput.Name = "RatingInput";
            this.RatingInput.Size = new System.Drawing.Size(200, 20);
            this.RatingInput.TabIndex = 5;
            this.RatingInput.TextChanged += new System.EventHandler(this.RatingInput_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(178, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // MovieTimeLabel
            // 
            this.MovieTimeLabel.AutoSize = true;
            this.MovieTimeLabel.Location = new System.Drawing.Point(178, 55);
            this.MovieTimeLabel.Name = "MovieTimeLabel";
            this.MovieTimeLabel.Size = new System.Drawing.Size(65, 13);
            this.MovieTimeLabel.TabIndex = 7;
            this.MovieTimeLabel.Text = "Movie Time:";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(178, 94);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(81, 13);
            this.ReleaseYearLabel.TabIndex = 8;
            this.ReleaseYearLabel.Text = "Year of release:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(178, 133);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 9;
            this.GenreLabel.Text = "Genre:";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(178, 172);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 10;
            this.RatingLabel.Text = "Rating:";
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Location = new System.Drawing.Point(239, 218);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(75, 23);
            this.FindFilmButton.TabIndex = 1;
            this.FindFilmButton.Text = "Find";
            this.FindFilmButton.UseVisualStyleBackColor = true;
            this.FindFilmButton.Click += new System.EventHandler(this.FindFilmButton_Click);
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
            this.SeasonBox.ResumeLayout(false);
            this.SeasonBox.PerformLayout();
            this.WeekdayBox.ResumeLayout(false);
            this.WeekdayBox.PerformLayout();
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesGroupBox.ResumeLayout(false);
            this.ClassesGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
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
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox ClassesGroupBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox ColorInput;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.TextBox LengthInput;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.TextBox ReleaseYearInput;
        private System.Windows.Forms.TextBox MovieTimeInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox RatingInput;
        private System.Windows.Forms.TextBox GenreInput;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.Label MovieTimeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button FindFilmButton;
    }
}

