using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksListApp.Model
{
    public class Book
    {
        private string title;

        private int releaseYear;

        private string author;

        private int numberOfPages;

        private string genre;

        public string Title
        {
            get { return title; }
            set
            {
                Validator.AssertValueContainsOnlyLetters(value, "Title");
                Validator.AssertValueInRange(value.Length, 0, 100, "Title");
                title = value;
            }
        }

        public int ReleaseYear
        {
            get { return releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 0, DateTime.Now.Year, "Release Year");
                releaseYear = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                Validator.AssertValueContainsOnlyLetters(value, "Title");
                Validator.AssertValueInRange(value.Length, 0, 100, "Title");
                author = value;
            }
        }

        public int NumberOfPages
        {
            get { return numberOfPages; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Number of pages");
                numberOfPages = value;
            }
        }

        public string Genre { get; set; }

        public Book(string title, int releaseYear, string author, int numberOfPages)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Author = author;
            NumberOfPages = numberOfPages;
            Genre = genre;
        }
    }
}
