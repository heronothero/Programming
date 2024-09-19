using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksListApp.Model
{
    public class Book
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public Genre Genre { get; set; }

        public Book(string title, int releaseYear, string author, int numberOfPages, Genre genre)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Author = author;
            NumberOfPages = numberOfPages;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Title} | {ReleaseYear} | {Author} | {NumberOfPages} | {Genre}";
        }
    }
}
