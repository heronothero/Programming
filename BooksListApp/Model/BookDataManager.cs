using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace BooksListApp.Model
{
    public class BookDataManager
    {
        private const string FilePath = "books.json";

        public static void SaveBooks(List<Book> books)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(books, options);
                File.WriteAllText(FilePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving books: {ex.Message}");
            }
        }

        public static List<Book> LoadBooks()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return new List<Book>();

                string jsonString = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Book>>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading books: {ex.Message}");
                return new List<Book>();
            }
        }
    }
}
