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
        private int pages;
        private Genre genre;

        /// <summary>
        /// A function of checking title: letters between 0 and 100.
        /// </summary>
        public string Title 
        { get { return title; } 
          set
            {
                Validator.AssertValueInRange(value, 0, 100, "Title");
                title = value;
            }
        }

        /// <summary>
        /// A function of checking release year, which must be between 1000 (my choice) and this year.
        /// </summary>
        public int ReleaseYear 
        { 
            get { return releaseYear; } 
            set
            {
                Validator.AssertReleaseYear(value, 1000, DateTime.Now.Year, "Release year");
                releaseYear = value;
            }
        }

        /// <summary>
        /// A function of checking author, which must contain only letters (can write name and surname).
        /// </summary>
        public string Author 
        { get { return author; }
          set
            {
                Validator.AssertValueContainsOnlyLetters(value, "Author");
                author = value;
            }
        }

        /// <summary>
        /// A function of checking pages, which must be a positive number.
        /// </summary>
        public int Pages 
        { get { return pages;}
          set
            {
                Validator.AssertOnPositiveValue(value, "Pages");
                pages = value;
            }
        }

        /// <summary>
        /// This is a combobox where user can choose avaliable options.
        /// </summary>
        public Genre Genre 
        { get { return genre;} 
          set
            {
                Validator.AssertGenre(value, "Genre");
                genre = value;
            }
        }

        /// <summary>
        /// A constructor of a book
        /// </summary>
        /// <param name="title"></param>
        /// <param name="releaseYear"></param>
        /// <param name="author"></param>
        /// <param name="pages"></param>
        /// <param name="genre"></param>
        public Book(string title, int releaseYear, string author, int pages, Genre genre)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Author = author;
            Pages = pages;
            Genre = genre;
        }

        /// <summary>
        /// A function of showing data of books (title, author and genre).
        /// </summary>
        /// <returns> The record. </returns>
        public override string ToString()
        {
            return $"{Title} | {Author} | {Genre}";
        }
    }
}
