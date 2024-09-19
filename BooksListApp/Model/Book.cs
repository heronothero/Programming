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
        public string Title 
        { get { return title; } 
          set
            {
                Validator.AssertValueInRange(value, 0, 100, "Title");
                title = value;
            }
        }
        public int ReleaseYear 
        { 
            get { return releaseYear; } 
            set
            {
                Validator.AssertReleaseYear(value, 1000, DateTime.Now.Year, "Release year");
                releaseYear = value;
            }
        }
        public string Author 
        { get { return author; }
          set
            {
                Validator.AssertValueContainsOnlyLetters(value, "Author");
                author = value;
            }
        }
        public int Pages 
        { get { return pages;}
          set
            {
                Validator.AssertOnPositiveValue(value, "Pages");
                pages = value;
            }
        }
        public Genre Genre 
        { get { return genre;} 
          set
            {
                Validator.AssertGenre(value, "Genre");
                genre = value;
            }
        }

        public Book(string title, int releaseYear, string author, int pages, Genre genre)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Author = author;
            Pages = pages;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Title} | {ReleaseYear} | {Author} | {Pages} | {Genre}";
        }
    }
}
