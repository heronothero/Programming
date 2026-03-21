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
            this.BookListControl = new BooksListApp.View.Panels.BookListControl();
            this.SuspendLayout();
            // 
            // bookListControl
            // 
            this.BookListControl.Location = new System.Drawing.Point(6, 11);
            this.BookListControl.Name = "BookListControl";
            this.BookListControl.Size = new System.Drawing.Size(611, 467);
            this.BookListControl.TabIndex = 0;
            this.BookListControl.Load += new System.EventHandler(this.BookListControl_Load);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 490);
            this.Controls.Add(this.BookListControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookForm";
            this.Text = "Books list";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private View.Panels.BookListControl bookListControl;
    }
}