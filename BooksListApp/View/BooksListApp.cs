using BooksListApp.Model;
using BooksListApp.View.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksListApp
{
    public partial class BookForm : Form
    {
        private BooksListApp.View.Panels.BookListControl BookListControl;
        public BookForm()
        {
            InitializeComponent();
            this.FormClosing += BookForm_FormClosing;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void BookListControl_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// A function of saving books when the form closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BookListControl.SaveBooksToFile();
        }
    }
}
