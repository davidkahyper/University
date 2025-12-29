using System.Runtime.InteropServices.Marshalling;

namespace Laba5
{
    public class Book
    {
        private string authorName;
        private BookTheme bookTheme;

        public string AuthorName
        {
            get { return authorName; }
        }

        public BookTheme BookThemee
        {
            get { return bookTheme; }
        }
        


        public Book(string authorName)
        {
            this.authorName = authorName;
        }
        
        public Book(string authorName, BookTheme bookTheme)
        {
            this.authorName = authorName;
            this.bookTheme = bookTheme;
        }
        
        public Book(BookTheme bookTheme, string authorName)
        {
            this.authorName = authorName;
            this.bookTheme = bookTheme;
        }
        
        public enum BookTheme { Научная, Проза, Стихи, Роман }

        public static string GetRandomAuthorName()
        {
            string[] possibleNames =
            {
                "Александр",
                "Дмитрий",
                "Максим",
                "Иван",
                "Артём",
                "Никита",
                "Михаил",
                "Егор",
                "Андрей",
                "Кирилл",
                "Сергей",
                "Владислав",
                "Роман",
                "Даниил",
                "Павел",
                "Илья",
                "Тимофей",
                "Вячеслав",
                "Олег",
                "Константин"
            };
            
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return possibleNames[random.Next(possibleNames.Length)];
        }

        public static BookTheme GetRandomBookTheme()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return (BookTheme) random.Next(Enum.GetNames(typeof(BookTheme)).Length);
        }

        public static List<Book> GenerateBooks(int amountOfBooks = 10)
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < amountOfBooks; i++)
            {
                Book book = new Book(Book.GetRandomAuthorName(), Book.GetRandomBookTheme());
                books.Add(book);
            }

            return books;
        }

        public static void PrintBooks(List<Book> books)
        {
            int counter = 0;
            foreach (var book in books)
            {
                counter++;
                Console.WriteLine($"{counter}: {book.authorName}, {book.bookTheme}");
            }
            Console.WriteLine();
        }

        public static void SortBooks(List<Book> books)
        {
            for (int j = 0; j < books.Count - 1; j++)
            {
                for (int i = 0; i < books.Count - 1 - j; i++)
                {
                    if (books[i].BookThemee > books[i + 1].BookThemee)
                    {
                        Book temp = books[i];
                        books[i] = books[i + 1];
                        books[i + 1] = temp;
                    }
                }
            }
        }

        public static void SortBooksByAuthor(List<Book> books)
        {
            for (int j = 0; j < books.Count - 1; j++)
            {
                for (int i = 0; i < books.Count - 1 - j; i++)
                {
                    if (String.Compare(books[i].authorName, books[i + 1].authorName) > 0) 
                    {
                        Book temp = books[i];
                        books[i] = books[i + 1];
                        books[i + 1] = temp;
                    }
                }
            }
        }
    }
    
   
}