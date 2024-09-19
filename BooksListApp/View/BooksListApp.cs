using BooksListApp.Model;
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
        private List<Book> books = new List<Book>();
        public BookForm()
        {
            InitializeComponent();
            InitialGenres();
            LoadBooksFromFile();
            InitializeToolTips();

            addBookPictureBox.MouseEnter += addBookPictureBox_MouseEnter;
            addBookPictureBox.MouseLeave += addBookPictureBox_MouseLeave;
            addBookPictureBox.MouseDown += addBookPictureBox_MouseDown;
            addBookPictureBox.MouseUp += addBookPictureBox_MouseUp;

            editBookPictureBox.MouseEnter += editBookPictureBox_MouseEnter;
            editBookPictureBox.MouseLeave += editBookPictureBox_MouseLeave;
            editBookPictureBox.MouseDown += editBookPictureBox_MouseDown;
            editBookPictureBox.MouseUp += editBookPictureBox_MouseUp;

            deleteBookPictureBox.MouseEnter += deleteBookPictureBox_MouseEnter;
            deleteBookPictureBox.MouseLeave += deleteBookPictureBox_MouseLeave;
            deleteBookPictureBox.MouseDown += deleteBookPictureBox_MouseDown;
            deleteBookPictureBox.MouseUp += deleteBookPictureBox_MouseUp;

            bookBox.SelectedIndexChanged += bookBox_SelectedIndexChanged;
            this.FormClosing += BookForm_FormClosing;
        }

        private void LoadBooksFromFile()
        {
            books = BookDataManager.LoadBooks();
            SortAndUpdateBookList();
        }

        private void SaveBooksToFile()
        {
            BookDataManager.SaveBooks(books);
        }

        private void InitialGenres()
        {
            foreach (Genre genre in Enum.GetValues(typeof(Genre)))
            {
                selectedBookGenreComboBox.Items.Add(genre);
            }
        }

        private Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        private void addBookPictureBox_MouseEnter(object sender, EventArgs e)
        {
            addBookPictureBox.Image = SetImageOpacity(Properties.Resources.addBookIcon, 0.8f);
        }

        private void addBookPictureBox_MouseLeave(object sender, EventArgs e)
        {
            addBookPictureBox.Image = SetImageOpacity(Properties.Resources.addBookIcon, 1f);
        }

        private void addBookPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            addBookPictureBox.Image = SetImageOpacity(Properties.Resources.addBookIcon, 0.6f);
        }

        private void addBookPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            addBookPictureBox.Image = SetImageOpacity(Properties.Resources.addBookIcon, 0.8f);
        }

        private void editBookPictureBox_MouseEnter(object sender, EventArgs e)
        {
            editBookPictureBox.Image = SetImageOpacity(Properties.Resources.editBookIcon, 0.8f);
        }

        private void editBookPictureBox_MouseLeave(object sender, EventArgs e)
        {
            editBookPictureBox.Image = SetImageOpacity(Properties.Resources.editBookIcon, 1f);
        }

        private void editBookPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            editBookPictureBox.Image = SetImageOpacity(Properties.Resources.editBookIcon, 0.6f);
        }

        private void editBookPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            editBookPictureBox.Image = SetImageOpacity(Properties.Resources.editBookIcon, 0.8f);
        }

        private void deleteBookPictureBox_MouseEnter(object sender, EventArgs e)
        {
            deleteBookPictureBox.Image = SetImageOpacity(Properties.Resources.deleteBookIcon, 0.8f);
        }

        private void deleteBookPictureBox_MouseLeave(object sender, EventArgs e)
        {
            deleteBookPictureBox.Image = SetImageOpacity(Properties.Resources.deleteBookIcon, 1f);
        }

        private void deleteBookPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            deleteBookPictureBox.Image = SetImageOpacity(Properties.Resources.deleteBookIcon, 0.6f);
        }

        private void deleteBookPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            deleteBookPictureBox.Image = SetImageOpacity(Properties.Resources.deleteBookIcon, 0.8f);
        }
        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void addBookPictureBox_Click(object sender, EventArgs e)
        {
            ValidateInput();
            if (selectedBookTitleBox.BackColor == Color.White &&
            selectedBookReleaseYearBox.BackColor == Color.White &&
            selectedBookAuthorBox.BackColor == Color.White &&
            selectedBookNumberOfPagesBox.BackColor == Color.White &&
            selectedBookGenreComboBox.BackColor == Color.White)
            {
                string title = selectedBookTitleBox.Text;
                int releaseYear = int.Parse(selectedBookReleaseYearBox.Text);
                string author = selectedBookAuthorBox.Text;
                int pages = int.Parse(selectedBookNumberOfPagesBox.Text);
                Genre genre = (Genre)selectedBookGenreComboBox.SelectedItem;

                Book newBook = new Book(title, releaseYear, author, pages, genre);
                books.Add(newBook);
                bookBox.Items.Add(newBook);
                SortAndUpdateBookList();
                ClearBookFields();
            }
        }

        private void ClearBookFields()
        {
            selectedBookTitleBox.Clear();
            selectedBookReleaseYearBox.Clear();
            selectedBookAuthorBox.Clear();
            selectedBookNumberOfPagesBox.Clear();
            selectedBookGenreComboBox.SelectedIndex = -1;
        }

        private void editBookPictureBox_Click(object sender, EventArgs e)
        {
            ValidateInput();
            if (bookBox.SelectedItem != null)
            {
                try
                {
                    Book selectedBook = (Book)bookBox.SelectedItem;

                    string title = selectedBookTitleBox.Text;
                    if (!int.TryParse(selectedBookReleaseYearBox.Text, out int releaseYear))
                    {
                        throw new ArgumentException("Invalid release year format.");
                    }
                    string author = selectedBookAuthorBox.Text;
                    if (!int.TryParse(selectedBookNumberOfPagesBox.Text, out int pages))
                    {
                        throw new ArgumentException("Invalid number of pages format.");
                    }
                    Genre genre = (Genre)selectedBookGenreComboBox.SelectedItem;

                    selectedBook.Title = title;
                    selectedBook.ReleaseYear = releaseYear;
                    selectedBook.Author = author;
                    selectedBook.Pages = pages;
                    selectedBook.Genre = genre;

                    int selectedIndex = bookBox.SelectedIndex;
                    bookBox.Items[selectedIndex] = selectedBook;

                    SortAndUpdateBookList();
                    ClearBookFields();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to edit.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBookPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookBox.SelectedIndex == -1)
                {
                    throw new ArgumentException("Please select a book to delete.");
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this book?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    var bookToRemove = (Book)bookBox.SelectedItem;
                    books.Remove(bookToRemove);
                    SortAndUpdateBookList();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SortAndUpdateBookList()
        {
            books = books.OrderBy(b => b.Title).ToList();
            bookBox.Items.Clear();
            foreach (var book in books)
            {
                bookBox.Items.Add(book);
            }
            if (bookBox.SelectedItem != null)
            {
                Book selectedBook = (Book)bookBox.SelectedItem;
                int index = books.IndexOf(selectedBook);
                if (index != -1)
                {
                    bookBox.SelectedIndex = index;
                }
                else
                {
                    bookBox.SelectedIndex = -1;
                }
            }
        }

        private void selectedBookTitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectedBookReleaseYearBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectedBookAuthorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectedBookNumberOfPagesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookBox.SelectedItem != null)
            {
                Book selectedBook = (Book)bookBox.SelectedItem;

                selectedBookTitleBox.Text = selectedBook.Title;
                selectedBookReleaseYearBox.Text = selectedBook.ReleaseYear.ToString();
                selectedBookAuthorBox.Text = selectedBook.Author;
                selectedBookNumberOfPagesBox.Text = selectedBook.Pages.ToString();
                selectedBookGenreComboBox.SelectedItem = selectedBook.Genre;
            }
        }

        private void selectedBookGenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValidateInput()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(selectedBookTitleBox.Text) || selectedBookTitleBox.Text.Length > 100)
            {
                selectedBookTitleBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                selectedBookTitleBox.BackColor = Color.White;
            }

            if (!int.TryParse(selectedBookReleaseYearBox.Text, out int releaseYear) || releaseYear < 1000 || releaseYear > DateTime.Now.Year)
            {
                selectedBookReleaseYearBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                selectedBookReleaseYearBox.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(selectedBookAuthorBox.Text))
            {
                selectedBookAuthorBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                selectedBookAuthorBox.BackColor = Color.White;
            }

            if (!int.TryParse(selectedBookNumberOfPagesBox.Text, out int pages) || pages <= 0)
            {
                selectedBookNumberOfPagesBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                selectedBookNumberOfPagesBox.BackColor = Color.White;
            }

            if (selectedBookGenreComboBox.SelectedItem == null)
            {
                selectedBookGenreComboBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                selectedBookGenreComboBox.BackColor = Color.White;
            }

            if (!isValid)
            {
                MessageBox.Show("Please correct the highlighted fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ToolTip toolTip = new ToolTip();

        private void InitializeToolTips()
        {
            toolTip.SetToolTip(selectedBookTitleBox, "Title must be between 1 and 100 characters.");
            toolTip.SetToolTip(selectedBookReleaseYearBox, "Release year must be between 1000 and the current year.");
            toolTip.SetToolTip(selectedBookAuthorBox, "Author name cannot be empty.");
            toolTip.SetToolTip(selectedBookNumberOfPagesBox, "Number of pages must be a positive number.");
            toolTip.SetToolTip(selectedBookGenreComboBox, "Please select a genre.");
        }

        private void BookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveBooksToFile();
        }
    }
}
