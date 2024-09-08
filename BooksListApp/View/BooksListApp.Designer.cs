
namespace BooksListApp
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.bookBox = new System.Windows.Forms.ListBox();
            this.addBookPictureBox = new System.Windows.Forms.PictureBox();
            this.editBookPictureBox = new System.Windows.Forms.PictureBox();
            this.deleteBookPictureBox = new System.Windows.Forms.PictureBox();
            this.selectedBookBox = new System.Windows.Forms.GroupBox();
            this.selectedBookGenreBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectedBookNumberOfPagesBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedBookAuthorBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedBookReleaseYearBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedBookTitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addBookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBookPictureBox)).BeginInit();
            this.selectedBookBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookBox
            // 
            this.bookBox.FormattingEnabled = true;
            this.bookBox.ItemHeight = 16;
            this.bookBox.Location = new System.Drawing.Point(12, 12);
            this.bookBox.Name = "bookBox";
            this.bookBox.Size = new System.Drawing.Size(326, 500);
            this.bookBox.TabIndex = 0;
            this.bookBox.SelectedIndexChanged += new System.EventHandler(this.bookBox_SelectedIndexChanged);
            // 
            // addBookPictureBox
            // 
            this.addBookPictureBox.Image = global::BooksListApp.Properties.Resources.addBookIcon;
            this.addBookPictureBox.Location = new System.Drawing.Point(12, 529);
            this.addBookPictureBox.Name = "addBookPictureBox";
            this.addBookPictureBox.Size = new System.Drawing.Size(50, 50);
            this.addBookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addBookPictureBox.TabIndex = 1;
            this.addBookPictureBox.TabStop = false;
            this.addBookPictureBox.Click += new System.EventHandler(this.addBookPictureBox_Click);
            // 
            // editBookPictureBox
            // 
            this.editBookPictureBox.Image = global::BooksListApp.Properties.Resources.editBookIcon;
            this.editBookPictureBox.Location = new System.Drawing.Point(88, 529);
            this.editBookPictureBox.Name = "editBookPictureBox";
            this.editBookPictureBox.Size = new System.Drawing.Size(50, 50);
            this.editBookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editBookPictureBox.TabIndex = 2;
            this.editBookPictureBox.TabStop = false;
            this.editBookPictureBox.Click += new System.EventHandler(this.editBookPictureBox_Click);
            // 
            // deleteBookPictureBox
            // 
            this.deleteBookPictureBox.Image = global::BooksListApp.Properties.Resources.deleteBookIcon;
            this.deleteBookPictureBox.Location = new System.Drawing.Point(163, 529);
            this.deleteBookPictureBox.Name = "deleteBookPictureBox";
            this.deleteBookPictureBox.Size = new System.Drawing.Size(50, 50);
            this.deleteBookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteBookPictureBox.TabIndex = 3;
            this.deleteBookPictureBox.TabStop = false;
            this.deleteBookPictureBox.Click += new System.EventHandler(this.deleteBookPictureBox_Click);
            // 
            // selectedBookBox
            // 
            this.selectedBookBox.Controls.Add(this.selectedBookGenreBox);
            this.selectedBookBox.Controls.Add(this.label5);
            this.selectedBookBox.Controls.Add(this.selectedBookNumberOfPagesBox);
            this.selectedBookBox.Controls.Add(this.label4);
            this.selectedBookBox.Controls.Add(this.selectedBookAuthorBox);
            this.selectedBookBox.Controls.Add(this.label3);
            this.selectedBookBox.Controls.Add(this.selectedBookReleaseYearBox);
            this.selectedBookBox.Controls.Add(this.label2);
            this.selectedBookBox.Controls.Add(this.selectedBookTitleBox);
            this.selectedBookBox.Controls.Add(this.label1);
            this.selectedBookBox.Location = new System.Drawing.Point(355, 12);
            this.selectedBookBox.Name = "selectedBookBox";
            this.selectedBookBox.Size = new System.Drawing.Size(465, 263);
            this.selectedBookBox.TabIndex = 4;
            this.selectedBookBox.TabStop = false;
            this.selectedBookBox.Text = "Selected book";
            // 
            // selectedBookGenreBox
            // 
            this.selectedBookGenreBox.Location = new System.Drawing.Point(132, 220);
            this.selectedBookGenreBox.Name = "selectedBookGenreBox";
            this.selectedBookGenreBox.Size = new System.Drawing.Size(314, 22);
            this.selectedBookGenreBox.TabIndex = 9;
            this.selectedBookGenreBox.TextChanged += new System.EventHandler(this.selectedBookGenreBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genre:";
            // 
            // selectedBookNumberOfPagesBox
            // 
            this.selectedBookNumberOfPagesBox.Location = new System.Drawing.Point(132, 174);
            this.selectedBookNumberOfPagesBox.Name = "selectedBookNumberOfPagesBox";
            this.selectedBookNumberOfPagesBox.Size = new System.Drawing.Size(314, 22);
            this.selectedBookNumberOfPagesBox.TabIndex = 7;
            this.selectedBookNumberOfPagesBox.TextChanged += new System.EventHandler(this.selectedBookNumberOfPagesBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of pages:";
            // 
            // selectedBookAuthorBox
            // 
            this.selectedBookAuthorBox.Location = new System.Drawing.Point(132, 125);
            this.selectedBookAuthorBox.Name = "selectedBookAuthorBox";
            this.selectedBookAuthorBox.Size = new System.Drawing.Size(314, 22);
            this.selectedBookAuthorBox.TabIndex = 5;
            this.selectedBookAuthorBox.TextChanged += new System.EventHandler(this.selectedBookAuthorBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author:";
            // 
            // selectedBookReleaseYearBox
            // 
            this.selectedBookReleaseYearBox.Location = new System.Drawing.Point(132, 80);
            this.selectedBookReleaseYearBox.Name = "selectedBookReleaseYearBox";
            this.selectedBookReleaseYearBox.Size = new System.Drawing.Size(314, 22);
            this.selectedBookReleaseYearBox.TabIndex = 3;
            this.selectedBookReleaseYearBox.TextChanged += new System.EventHandler(this.selectedBookReleaseYearBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Release year:";
            // 
            // selectedBookTitleBox
            // 
            this.selectedBookTitleBox.Location = new System.Drawing.Point(132, 33);
            this.selectedBookTitleBox.Name = "selectedBookTitleBox";
            this.selectedBookTitleBox.Size = new System.Drawing.Size(314, 22);
            this.selectedBookTitleBox.TabIndex = 1;
            this.selectedBookTitleBox.TextChanged += new System.EventHandler(this.selectedBookTitleBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.selectedBookBox);
            this.Controls.Add(this.deleteBookPictureBox);
            this.Controls.Add(this.editBookPictureBox);
            this.Controls.Add(this.addBookPictureBox);
            this.Controls.Add(this.bookBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookForm";
            this.Text = "Books list";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addBookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBookPictureBox)).EndInit();
            this.selectedBookBox.ResumeLayout(false);
            this.selectedBookBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bookBox;
        private System.Windows.Forms.PictureBox addBookPictureBox;
        private System.Windows.Forms.PictureBox editBookPictureBox;
        private System.Windows.Forms.PictureBox deleteBookPictureBox;
        private System.Windows.Forms.GroupBox selectedBookBox;
        private System.Windows.Forms.TextBox selectedBookGenreBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox selectedBookNumberOfPagesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox selectedBookAuthorBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selectedBookReleaseYearBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selectedBookTitleBox;
        private System.Windows.Forms.Label label1;
    }
}

