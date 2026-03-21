namespace Programming.View.Panels
{
    partial class MoviesControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox4.Location = new System.Drawing.Point(3, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(395, 352);
            this.groupBox4.TabIndex = 2;
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
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(400, 360);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button movieRatingButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox releaseYearBox;
        private System.Windows.Forms.TextBox movieTimeBox;
        private System.Windows.Forms.TextBox movieNameBox;
        private System.Windows.Forms.ListBox moviesBox;
    }
}
