// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Xml.Schema;

namespace Laba5
{
    public class Program
    {
        public static void Main()
        {
            // Testing test = new Testing();
            // test.TestEnum();

            // Program a =  new Program();
            // a.TestJob();

            // TestStudent();

            // TestBook();
        }
        
        private static void TestBook()
        {
            int amountOfBooks = 10, amountOfShelves = 3;

            List<Book> books = Book.GenerateBooks();
            List<List<Book>> shelves = new List<List<Book>>();
            for (int i = 0; i < amountOfShelves; i++)
            {
                shelves.Add(new List<Book>());
            }
            
            Book.SortBooks(books);
            
            for (int i = 0; i < amountOfBooks; i++)
            {
                Book book = books[i];
                shelves[i%amountOfShelves].Add(book);
            }

            foreach (List<Book> shelf in shelves)
            {
                Book.SortBooksByAuthor(shelf);
                Book.PrintBooks(shelf);
            }
        }

        private static void TestStudent()
        {
            int amountOfStudents = 10, amountOfGrous = 3;

            List<Student> students = Student.GenerateStudent();
            List<List<Student>> groups = new List<List<Student>>();
            for (int i = 0; i < amountOfGrous; i++)
            {
                groups.Add(new List<Student>());
            }
            
            Student.SortStudents(students);
            
            for (int i = 0; i < amountOfStudents; i++)
            {
                Student student = students[i];
                groups[i%amountOfGrous].Add(student);
            }

            foreach (List<Student> group in groups)
            {
                Student.SortStudentsBySurname(group);
                Student.PrintStudents(group);
            }
        }
        
        private void TestJob()
        {
            Prog_Properties pattern = Prog_Properties.C_Sharp | Prog_Properties.Web;
            Console.WriteLine("Требования, заданные образцом: "+ "Знание языка C# и Web-технологий");

            int n = 10;
            Job mys = new Job(n);
            mys.FormCands();
            Prog_Properties[] cand = mys.GetCands();
            string[] strCand = mys.GetStrCands();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Свойства кандидата {i}: {cand[i]}");
                Console.WriteLine(strCand[i]);
            }
            
            mys.Pattern = pattern;
            ArrayList result;
            result = mys.CandsHavePat();
            
            Console.WriteLine("Кандидаты, имеющие заданные свойства");
            foreach (string pretender in result) Console.WriteLine(pretender);
                
            result = mys.CandHaveNotAllPat();
            Console.WriteLine("Кандидаты, не имеющие всех свойств");
            foreach (string pretender in result) Console.WriteLine(pretender);
            
            result = mys.CandHaveSomePat();
            Console.WriteLine("Кандидаты, имеющие некоторые свойства");
            foreach (string pretender in result) Console.WriteLine(pretender);
            
            result= mys.CandHaveOnlyPat();
            Console.WriteLine("Кандидаты, имеющие только заданные свойства");
            foreach (string pretender in result) Console.WriteLine(pretender);
        }

        
    }
}