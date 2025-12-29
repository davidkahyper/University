using System.Runtime.InteropServices.Marshalling;

namespace Laba5
{
    public class Student
    {
        private string name;
        private Facultet facultet;

        public string Name
        {
            get { return name; }
        }

        public Facultet BookTheme
        {
            get { return facultet; }
        }
        

        


        public Student(string name)
        {
            this.name = name;
        }
        
        public Student(string name, Facultet facultet)
        {
            this.name = name;
            this.facultet = facultet;
        }
        
        public Student(Facultet facultet, string name)
        {
            this.name = name;
            this.facultet = facultet;
        }
        
        public enum Facultet { Математический, Лингвистический, Экономический, Музыкальный }

        public static string GetRandomName()
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

        public static Facultet GetRandomFacultet()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return (Facultet) random.Next(Enum.GetNames(typeof(Facultet)).Length);
        }

        public static List<Student> GenerateStudent(int amountOfStudents = 10)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < amountOfStudents; i++)
            {
                Student student = new Student(Student.GetRandomName(), Student.GetRandomFacultet());
                students.Add(student);
            }

            return students;
        }

        public static void PrintStudents(List<Student> students)
        {
            int counter = 0;
            foreach (var student     in students)
            {
                counter++;
                Console.WriteLine($"{counter}: {student    .Name}, {student    .BookTheme}");
            }
            Console.WriteLine();
        }

        public static void SortStudents(List<Student> students)
        {
            for (int j = 0; j < students.Count - 1; j++)
            {
                for (int i = 0; i < students.Count - 1 - j; i++)
                {
                    if (students[i].BookTheme > students[i + 1].BookTheme)
                    {
                        Student temp = students[i];
                        students[i] = students[i + 1];
                        students[i + 1] = temp;
                    }
                }
            }
        }
        
        public static void SortStudentsBySurname(List<Student> students)
        {
            for (int j = 0; j < students.Count - 1; j++)
            {
                for (int i = 0; i < students.Count - 1 - j; i++)
                {
                    if (String.Compare(students[i].name, students[i + 1].name) > 0)
                    {
                        Student temp = students[i];
                        students[i] = students[i + 1];
                        students[i + 1] = temp;
                    }
                }
            }
        }
    }
    
   
}