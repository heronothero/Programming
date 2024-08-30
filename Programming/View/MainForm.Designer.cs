
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.collisionRingsBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.collisionRectanglesBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.outerRadiusBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.innerRadiusBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ringsBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.movieRatingButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.releaseYearBox = new System.Windows.Forms.TextBox();
            this.movieTimeBox = new System.Windows.Forms.TextBox();
            this.movieNameBox = new System.Windows.Forms.TextBox();
            this.moviesBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.seasonHandleControl1 = new Programming.View.Panels.SeasonHandleControl();
            this.weekdayParsingControl1 = new Programming.View.Panels.WeekdayParsingControl();
            this.enumerationControl = new Programming.View.Panels.EnumerationControl();
            this.rectanglesCollisionControl = new Programming.View.Panels.RectanglesCollisionControl();
            this.rectanglesControl1 = new Programming.View.Panels.RectanglesControl();
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.seasonHandleControl1);
            this.Enums.Controls.Add(this.weekdayParsingControl1);
            this.Enums.Controls.Add(this.enumerationControl);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Margin = new System.Windows.Forms.Padding(2);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(2);
            this.Enums.Size = new System.Drawing.Size(776, 535);
            this.Enums.TabIndex = 1;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rectanglesControl1);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(776, 535);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.collisionRingsBox);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.collisionRectanglesBox);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Location = new System.Drawing.Point(374, 369);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(394, 158);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Collision";
            // 
            // collisionRingsBox
            // 
            this.collisionRingsBox.Location = new System.Drawing.Point(37, 101);
            this.collisionRingsBox.Name = "collisionRingsBox";
            this.collisionRingsBox.Size = new System.Drawing.Size(324, 20);
            this.collisionRingsBox.TabIndex = 3;
            this.collisionRingsBox.TextChanged += new System.EventHandler(this.collisionRingsBox_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Rings collision";
            // 
            // collisionRectanglesBox
            // 
            this.collisionRectanglesBox.Location = new System.Drawing.Point(37, 55);
            this.collisionRectanglesBox.Name = "collisionRectanglesBox";
            this.collisionRectanglesBox.Size = new System.Drawing.Size(324, 20);
            this.collisionRectanglesBox.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Rectangles collision";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.areaBox);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.outerRadiusBox);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.innerRadiusBox);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.ringsBox);
            this.groupBox5.Location = new System.Drawing.Point(13, 369);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 158);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rings";
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(157, 117);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(167, 20);
            this.areaBox.TabIndex = 6;
            this.areaBox.TextChanged += new System.EventHandler(this.areaBox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(155, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Area";
            // 
            // outerRadiusBox
            // 
            this.outerRadiusBox.Location = new System.Drawing.Point(156, 78);
            this.outerRadiusBox.Name = "outerRadiusBox";
            this.outerRadiusBox.Size = new System.Drawing.Size(168, 20);
            this.outerRadiusBox.TabIndex = 4;
            this.outerRadiusBox.TextChanged += new System.EventHandler(this.outerRadiusBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(155, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Outer Radius";
            // 
            // innerRadiusBox
            // 
            this.innerRadiusBox.Location = new System.Drawing.Point(156, 38);
            this.innerRadiusBox.Name = "innerRadiusBox";
            this.innerRadiusBox.Size = new System.Drawing.Size(168, 20);
            this.innerRadiusBox.TabIndex = 2;
            this.innerRadiusBox.TextChanged += new System.EventHandler(this.innerRadiusBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(155, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Inner Radius";
            // 
            // ringsBox
            // 
            this.ringsBox.FormattingEnabled = true;
            this.ringsBox.Location = new System.Drawing.Point(10, 19);
            this.ringsBox.Name = "ringsBox";
            this.ringsBox.Size = new System.Drawing.Size(133, 121);
            this.ringsBox.TabIndex = 0;
            this.ringsBox.SelectedIndexChanged += new System.EventHandler(this.ringsBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.movieRatingButton);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.ratingBox);
            this.groupBox4.Controls.Add(this.genreBox);
            this.groupBox4.Controls.Add(this.releaseYearBox);
            this.groupBox4.Controls.Add(this.movieTimeBox);
            this.groupBox4.Controls.Add(this.movieNameBox);
            this.groupBox4.Controls.Add(this.moviesBox);
            this.groupBox4.Location = new System.Drawing.Point(374, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(395, 352);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Movies";
            // 
            // movieRatingButton
            // 
            this.movieRatingButton.Location = new System.Drawing.Point(160, 305);
            this.movieRatingButton.Margin = new System.Windows.Forms.Padding(2);
            this.movieRatingButton.Name = "movieRatingButton";
            this.movieRatingButton.Size = new System.Drawing.Size(174, 30);
            this.movieRatingButton.TabIndex = 2;
            this.movieRatingButton.Text = "Find";
            this.movieRatingButton.UseVisualStyleBackColor = true;
            this.movieRatingButton.Click += new System.EventHandler(this.movieRatingButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(157, 230);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Rating";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Genre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Year of release";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Duration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name of the movie";
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(158, 246);
            this.ratingBox.Margin = new System.Windows.Forms.Padding(2);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(175, 20);
            this.ratingBox.TabIndex = 7;
            this.ratingBox.TextChanged += new System.EventHandler(this.ratingBox_TextChanged);
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(158, 193);
            this.genreBox.Margin = new System.Windows.Forms.Padding(2);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(175, 20);
            this.genreBox.TabIndex = 6;
            this.genreBox.TextChanged += new System.EventHandler(this.genreBox_TextChanged);
            // 
            // releaseYearBox
            // 
            this.releaseYearBox.Location = new System.Drawing.Point(158, 139);
            this.releaseYearBox.Margin = new System.Windows.Forms.Padding(2);
            this.releaseYearBox.Name = "releaseYearBox";
            this.releaseYearBox.Size = new System.Drawing.Size(175, 20);
            this.releaseYearBox.TabIndex = 5;
            this.releaseYearBox.TextChanged += new System.EventHandler(this.releaseYearBox_TextChanged);
            // 
            // movieTimeBox
            // 
            this.movieTimeBox.Location = new System.Drawing.Point(159, 86);
            this.movieTimeBox.Margin = new System.Windows.Forms.Padding(2);
            this.movieTimeBox.Name = "movieTimeBox";
            this.movieTimeBox.Size = new System.Drawing.Size(175, 20);
            this.movieTimeBox.TabIndex = 4;
            this.movieTimeBox.TextChanged += new System.EventHandler(this.movieTimeBox_TextChanged);
            // 
            // movieNameBox
            // 
            this.movieNameBox.Location = new System.Drawing.Point(159, 35);
            this.movieNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.movieNameBox.Name = "movieNameBox";
            this.movieNameBox.Size = new System.Drawing.Size(175, 20);
            this.movieNameBox.TabIndex = 3;
            this.movieNameBox.TextChanged += new System.EventHandler(this.movieNameBox_TextChanged);
            // 
            // moviesBox
            // 
            this.moviesBox.FormattingEnabled = true;
            this.moviesBox.Location = new System.Drawing.Point(9, 20);
            this.moviesBox.Margin = new System.Windows.Forms.Padding(2);
            this.moviesBox.Name = "moviesBox";
            this.moviesBox.Size = new System.Drawing.Size(137, 316);
            this.moviesBox.TabIndex = 2;
            this.moviesBox.SelectedIndexChanged += new System.EventHandler(this.moviesBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rectanglesCollisionControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(776, 535);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Rectangles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.Location = new System.Drawing.Point(359, 3);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(397, 135);
            this.seasonHandleControl1.TabIndex = 7;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(359, 195);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(397, 165);
            this.weekdayParsingControl1.TabIndex = 6;
            // 
            // enumerationControl
            // 
            this.enumerationControl.Location = new System.Drawing.Point(8, 0);
            this.enumerationControl.Name = "enumerationControl";
            this.enumerationControl.Size = new System.Drawing.Size(330, 360);
            this.enumerationControl.TabIndex = 5;
            // 
            // rectanglesCollisionControl
            // 
            this.rectanglesCollisionControl.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl.Name = "rectanglesCollisionControl";
            this.rectanglesCollisionControl.Size = new System.Drawing.Size(776, 535);
            this.rectanglesCollisionControl.TabIndex = 0;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(8, 8);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(350, 360);
            this.rectanglesControl1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox moviesBox;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox releaseYearBox;
        private System.Windows.Forms.TextBox movieTimeBox;
        private System.Windows.Forms.TextBox movieNameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button movieRatingButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox ringsBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox outerRadiusBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox innerRadiusBox;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox collisionRingsBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox collisionRectanglesBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage2;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl;
        private View.Panels.EnumerationControl enumerationControl;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonHandleControl seasonHandleControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
    }
}

