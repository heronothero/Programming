namespace BooksListApp.View.Panels
{
    partial class BookListControl
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
            this.selectedBookBox = new System.Windows.Forms.GroupBox();
            this.selectedBookGenreComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectedBookNumberOfPagesBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedBookAuthorBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedBookReleaseYearBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedBookTitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookBox = new System.Windows.Forms.ListBox();
            this.deleteBookPictureBox = new System.Windows.Forms.PictureBox();
            this.editBookPictureBox = new System.Windows.Forms.PictureBox();
            this.addBookPictureBox = new System.Windows.Forms.PictureBox();
            this.selectedBookBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedBookBox
            // 
            this.selectedBookBox.Controls.Add(this.selectedBookGenreComboBox);
            this.selectedBookBox.Controls.Add(this.label5);
            this.selectedBookBox.Controls.Add(this.selectedBookNumberOfPagesBox);
            this.selectedBookBox.Controls.Add(this.label4);
            this.selectedBookBox.Controls.Add(this.selectedBookAuthorBox);
            this.selectedBookBox.Controls.Add(this.label3);
            this.selectedBookBox.Controls.Add(this.selectedBookReleaseYearBox);
            this.selectedBookBox.Controls.Add(this.label2);
            this.selectedBookBox.Controls.Add(this.selectedBookTitleBox);
            this.selectedBookBox.Controls.Add(this.label1);
            this.selectedBookBox.Location = new System.Drawing.Point(259, 2);
            this.selectedBookBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectedBookBox.Name = "selectedBookBox";
            this.selectedBookBox.Padding = new System.Windows.Forms.Padding(2);
            this.selectedBookBox.Size = new System.Drawing.Size(349, 214);
            this.selectedBookBox.TabIndex = 9;
            this.selectedBookBox.TabStop = false;
            this.selectedBookBox.Text = "Selected book";
            // 
            // selectedBookGenreComboBox
            // 
            this.selectedBookGenreComboBox.FormattingEnabled = true;
            this.selectedBookGenreComboBox.Location = new System.Drawing.Point(99, 176);
            this.selectedBookGenreComboBox.Name = "selectedBookGenreComboBox";
            this.selectedBookGenreComboBox.Size = new System.Drawing.Size(236, 21);
            this.selectedBookGenreComboBox.TabIndex = 9;
            this.selectedBookGenreComboBox.SelectedIndexChanged += new System.EventHandler(this.selectedBookGenreComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genre:";
            // 
            // selectedBookNumberOfPagesBox
            // 
            this.selectedBookNumberOfPagesBox.Location = new System.Drawing.Point(99, 141);
            this.selectedBookNumberOfPagesBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectedBookNumberOfPagesBox.Name = "selectedBookNumberOfPagesBox";
            this.selectedBookNumberOfPagesBox.Size = new System.Drawing.Size(236, 20);
            this.selectedBookNumberOfPagesBox.TabIndex = 7;
            this.selectedBookNumberOfPagesBox.TextChanged += new System.EventHandler(this.selectedBookNumberOfPagesBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of pages:";
            // 
            // selectedBookAuthorBox
            // 
            this.selectedBookAuthorBox.Location = new System.Drawing.Point(99, 102);
            this.selectedBookAuthorBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectedBookAuthorBox.Name = "selectedBookAuthorBox";
            this.selectedBookAuthorBox.Size = new System.Drawing.Size(236, 20);
            this.selectedBookAuthorBox.TabIndex = 5;
            this.selectedBookAuthorBox.TextChanged += new System.EventHandler(this.selectedBookAuthorBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author:";
            // 
            // selectedBookReleaseYearBox
            // 
            this.selectedBookReleaseYearBox.Location = new System.Drawing.Point(99, 65);
            this.selectedBookReleaseYearBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectedBookReleaseYearBox.Name = "selectedBookReleaseYearBox";
            this.selectedBookReleaseYearBox.Size = new System.Drawing.Size(236, 20);
            this.selectedBookReleaseYearBox.TabIndex = 3;
            this.selectedBookReleaseYearBox.TextChanged += new System.EventHandler(this.selectedBookReleaseYearBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Release year:";
            // 
            // selectedBookTitleBox
            // 
            this.selectedBookTitleBox.Location = new System.Drawing.Point(99, 27);
            this.selectedBookTitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectedBookTitleBox.Name = "selectedBookTitleBox";
            this.selectedBookTitleBox.Size = new System.Drawing.Size(236, 20);
            this.selectedBookTitleBox.TabIndex = 1;
            this.selectedBookTitleBox.TextChanged += new System.EventHandler(this.selectedBookTitleBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // bookBox
            // 
            this.bookBox.FormattingEnabled = true;
            this.bookBox.Location = new System.Drawing.Point(2, 2);
            this.bookBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookBox.Name = "bookBox";
            this.bookBox.Size = new System.Drawing.Size(246, 407);
            this.bookBox.TabIndex = 5;
            this.bookBox.SelectedIndexChanged += new System.EventHandler(this.bookBox_SelectedIndexChanged);
            // 
            // deleteBookPictureBox
            // 
            this.deleteBookPictureBox.Image = global::BooksListApp.Properties.Resources.deleteBookIcon;
            this.deleteBookPictureBox.Location = new System.Drawing.Point(115, 422);
            this.deleteBookPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBookPictureBox.Name = "deleteBookPictureBox";
            this.deleteBookPictureBox.Size = new System.Drawing.Size(38, 41);
            this.deleteBookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteBookPictureBox.TabIndex = 8;
            this.deleteBookPictureBox.TabStop = false;
            this.deleteBookPictureBox.Click += new System.EventHandler(this.deleteBookPictureBox_Click);
            // 
            // editBookPictureBox
            // 
            this.editBookPictureBox.Image = global::BooksListApp.Properties.Resources.editBookIcon;
            this.editBookPictureBox.Location = new System.Drawing.Point(59, 422);
            this.editBookPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.editBookPictureBox.Name = "editBookPictureBox";
            this.editBookPictureBox.Size = new System.Drawing.Size(38, 41);
            this.editBookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editBookPictureBox.TabIndex = 7;
            this.editBookPictureBox.TabStop = false;
            this.editBookPictureBox.Click += new System.EventHandler(this.editBookPictureBox_Click);
            // 
            // addBookPictureBox
            // 
            this.addBookPictureBox.Image = global::BooksListApp.Properties.Resources.addBookIcon;
            this.addBookPictureBox.Location = new System.Drawing.Point(2, 422);
            this.addBookPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.addBookPictureBox.Name = "addBookPictureBox";
            this.addBookPictureBox.Size = new System.Drawing.Size(38, 41);
            this.addBookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addBookPictureBox.TabIndex = 6;
            this.addBookPictureBox.TabStop = false;
            this.addBookPictureBox.Click += new System.EventHandler(this.addBookPictureBox_Click);
            // 
            // BookListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectedBookBox);
            this.Controls.Add(this.deleteBookPictureBox);
            this.Controls.Add(this.editBookPictureBox);
            this.Controls.Add(this.addBookPictureBox);
            this.Controls.Add(this.bookBox);
            this.Name = "BookListControl";
            this.Size = new System.Drawing.Size(611, 467);
            this.selectedBookBox.ResumeLayout(false);
            this.selectedBookBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox selectedBookBox;
        private System.Windows.Forms.ComboBox selectedBookGenreComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox selectedBookNumberOfPagesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox selectedBookAuthorBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selectedBookReleaseYearBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selectedBookTitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox deleteBookPictureBox;
        private System.Windows.Forms.PictureBox editBookPictureBox;
        private System.Windows.Forms.PictureBox addBookPictureBox;
        private System.Windows.Forms.ListBox bookBox;
    }
}
