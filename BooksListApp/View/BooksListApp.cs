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
        public BookForm()
        {
            InitializeComponent();
            InitialGenres();

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
        }

        private void InitialGenres()
        {
            selectedBookGenreComboBox.Items.Add(Genre.Action);
            selectedBookGenreComboBox.Items.Add(Genre.Adventures);
            selectedBookGenreComboBox.Items.Add(Genre.Comedy);
            selectedBookGenreComboBox.Items.Add(Genre.Detective);
            selectedBookGenreComboBox.Items.Add(Genre.Drama);
            selectedBookGenreComboBox.Items.Add(Genre.Fantasy);
            selectedBookGenreComboBox.Items.Add(Genre.History);
            selectedBookGenreComboBox.Items.Add(Genre.Horror);
            selectedBookGenreComboBox.Items.Add(Genre.Manga);
            selectedBookGenreComboBox.Items.Add(Genre.Mysticism);
            selectedBookGenreComboBox.Items.Add(Genre.Novel);
            selectedBookGenreComboBox.Items.Add(Genre.Poetry);
            selectedBookGenreComboBox.Items.Add(Genre.Romance);
            selectedBookGenreComboBox.Items.Add(Genre.Science);
            selectedBookGenreComboBox.Items.Add(Genre.Thriller);
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
            try
            {
                if (string.IsNullOrWhiteSpace(selectedBookTitleBox.Text) ||
                    string.IsNullOrWhiteSpace(selectedBookAuthorBox.Text) ||
                    string.IsNullOrWhiteSpace(selectedBookReleaseYearBox.Text) ||
                    string.IsNullOrWhiteSpace(selectedBookNumberOfPagesBox.Text) ||
                    selectedBookGenreComboBox.SelectedItem == null)
                {
                    throw new ArgumentException("All fields must be filled in.");
                }
                string title = selectedBookTitleBox.Text;
                int releaseYear = int.Parse(selectedBookReleaseYearBox.Text);
                string author = selectedBookAuthorBox.Text;
                int pages = int.Parse(selectedBookNumberOfPagesBox.Text);
                Genre genre = (Genre)selectedBookGenreComboBox.SelectedItem;

                Validator.AssertValueInRange(title, 0, 100, "Title");
                Validator.AssertReleaseYear(releaseYear, 1000, DateTime.Now.Year, "Release year");
                Validator.AssertValueContainsOnlyLetters(author, "Author");
                Validator.AssertOnPositiveValue(pages, "Pages");
                Validator.AssertGenre(genre, "Genre");

                Book newBook = new Book(title, releaseYear, author, pages, genre);
                bookBox.Items.Add(newBook);
                ClearBookFields();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    bookBox.Items.RemoveAt(bookBox.SelectedIndex);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }

        private void selectedBookGenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
