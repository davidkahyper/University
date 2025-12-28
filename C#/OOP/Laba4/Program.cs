using System.ComponentModel.Design;

namespace Laba4
{
    class Program
    {
        public static void Main()
        {
            // Task4_4_1_a();
            // Task4_4_1_b();
            
            // Task4_4_2_1();
            // Task4_4_2_2();

            // Task4_4_3();

            Task4_4_4();
        }
        
        public static void Task4_4_4()
        {
            int[] scores;
            int N = 10;

            scores = ArrayFill(N, "scores");
            ArrayPrint(scores, "scores");

            foreach (int score in scores)
            {
                if (score == 3)
                {
                    Console.WriteLine("Раньше была первая победа!");
                    return;
                }
                else if (score == 0)
                {
                    Console.WriteLine("Раньше был первый проигрыш!");
                    return;
                }
            }
            Console.WriteLine("Команда не разу не выиграла и не проиграла!");
        }

        public static void Task4_4_3()
        {
            int[] peoples;
            int N = 30;
            
            peoples = ArrayFill(N, "years");
            ArrayPrint(peoples, "peoples");
            
            Console.WriteLine();
            
            int min = peoples.Min();
            int first = -1, last = -1;
            
            for (int i = 0; i < N; i++)
            {
                if (peoples[i] == min)
                {
                    if (first == -1) first = i + 1;
                    else last = i + 1;
                }
            }

            if (last == -1)
            {
                Console.WriteLine("В списке только один самый старый человек, его год равен: " + min);
            }
            else
            {
                Console.WriteLine("В списке было найдено несколько человек, с самым старым возрастом. Номер первого: " + first + ", номер последнего: " + last + " и их год равен: " + min);
            }
        }

        public static void Task4_4_2_2()
        {
            int[] numbers1, numbers2, numbers3;
            int N = 20;
            numbers1 = ArrayFill(N);
            numbers2 = ArrayFill(N);
            numbers3 = new int[N];
            Console.WriteLine("Базовая генерация:");
            Program.ArrayPrint(numbers1, "numbers1");
            Program.ArrayPrint(numbers2, "numbers2");

            Console.WriteLine("Задание 4.4.2 1");

            int goals_zabito_v = 0, goals_zabito_n = 0, goals_zabito_p = 0;
            int goals_prop_v = 0, goals_prop_n = 0, goals_prop_p = 0;
            int wins = 0, draws = 0, losses = 0;

            for (int i = 0; i < N; i++)
            {
                numbers3[i] = numbers1[i] - numbers2[i];
                if (numbers3[i] > 0)
                {
                    Console.WriteLine("Победа!");
                    goals_zabito_v += numbers1[i];
                    goals_prop_v += numbers2[i];
                    wins++;
                }
                else if (numbers3[i] == 0)
                {
                    Console.WriteLine("Ничья.");
                    goals_zabito_n += numbers1[i];
                    goals_prop_n += numbers2[i];
                    draws++;
                }
                else 
                {
                    Console.WriteLine("Проигрыш.");
                    goals_zabito_p += numbers1[i];
                    goals_prop_p += numbers2[i];
                    losses++;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Cтатистика:");
            Console.WriteLine("Всего побед: " + wins);
            Console.WriteLine("Всего ничей: " + draws);
            Console.WriteLine("Всего проигрышей: " + losses);
            Console.WriteLine("Голов забито в выигрышных матчах:" + goals_zabito_v);
            Console.WriteLine("Голов пропущено в выигрышных матчах:"  + goals_prop_v);
            Console.WriteLine("Голов забито в ничье:" + goals_zabito_n);
            Console.WriteLine("Голов прощено в ничье:" + goals_prop_n);
            Console.WriteLine("Голов забито в проигрышных:" + goals_zabito_p);
            Console.WriteLine("Голов пропущено в проигрышных:" + goals_prop_p);
            Console.WriteLine();
        }

        public static void Task4_4_2_1()
        {
            int[] numbers1, numbers2;
            int N = 20;
            numbers1 = ArrayFill(N);
            numbers2 = ArrayFill(N);
            Console.WriteLine("Базовая генерация:");
            Program.ArrayPrint(numbers1, "numbers1");
            Program.ArrayPrint(numbers2, "numbers2");
     
            Console.WriteLine("Задание 4.4.2 1");
            
            int goals_zabito_v = 0, goals_zabito_n = 0, goals_zabito_p = 0;
            int goals_prop_v = 0, goals_prop_n = 0, goals_prop_p = 0;
            int wins = 0, draws = 0, losses = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"i: {i}, array1: {numbers1[i]}, array2: {numbers2[i]}");
                if (numbers1[i] - numbers2[i] > 0)
                {
                    Console.WriteLine("Победа!");
                    goals_zabito_v += numbers1[i];
                    goals_prop_v += numbers2[i];
                    wins++;
                }
                else if (numbers1[i] - numbers2[i] == 0)
                {
                    Console.WriteLine("Ничья.");
                    goals_zabito_n += numbers1[i];
                    goals_prop_n += numbers2[i];
                    draws++;
                }
                else 
                {
                    Console.WriteLine("Проигрыш.");
                    goals_zabito_p += numbers1[i];
                    goals_prop_p += numbers2[i];
                    losses++;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Cтатистика:");
            Console.WriteLine("Всего побед: " + wins);
            Console.WriteLine("Всего ничей: " + draws);
            Console.WriteLine("Всего проигрышей: " + losses);
            Console.WriteLine("Голов забито в выигрышных матчах:" + goals_zabito_v);
            Console.WriteLine("Голов пропущено в выигрышных матчах:"  + goals_prop_v);
            Console.WriteLine("Голов забито в ничье:" + goals_zabito_n);
            Console.WriteLine("Голов прощено в ничье:" + goals_prop_n);
            Console.WriteLine("Голов забито в проигрышных:" + goals_zabito_p);
            Console.WriteLine("Голов пропущено в проигрышных:" + goals_prop_p);
            Console.WriteLine();
        }
        
        public static void Task4_4_1_a()
        {
            int N = 10;
            int[] numbers1 = ArrayFill(N);
            int[] numbers2 = ArrayFill(N);
            
            Console.WriteLine("Базовая генерация:");
            Program.ArrayPrint(numbers1, "numbers1");
            Program.ArrayPrint(numbers2, "numbers2");
            
            for (int i = 1; i < N; i += 2)
            {
                numbers2[i] = numbers1[i];
            }
            ArrayPrint(numbers1, "numbers1");
            ArrayPrint(numbers2, "numbers2");
        }
        
        public static void Task4_4_1_b()
        {
            int N = 10;
            int[] numbers1 = ArrayFill(N);
            int[] numbers2 = ArrayFill(N);
            
            Console.WriteLine("Базовая генерация:");
            Program.ArrayPrint(numbers1, "numbers1");
            Program.ArrayPrint(numbers2, "numbers2");
            
            for (int i = 0; i < N; i += 2)
            {
                numbers2[i] = numbers1[i];
            }
            ArrayPrint(numbers1, "numbers1");
            ArrayPrint(numbers2, "numbers2");
        }

        public static int[] ArrayFill(int N)
        {
            int[] array = new int[N]; 
            Random rnd = new Random(Guid.NewGuid().GetHashCode()); //эту часть посмотрел в интернете, как получить случайное число.
            // Изначально хотел через DateTime.Now.Millisecond, но бывали ситуации когда выполнялось слишком быстром и генерировались одинаковые числа
            for (int i = 0; i < N; i++)
            {
                array[i] = rnd.Next(0, 101);
            }
            return array;
        }
        
        public static int[] ArrayFill(int N, string statement)
        {
            int min, max;
            if (statement == "years")
            {
                min = 1960;
                max = 2011;
            }
            else if (statement == "scores")
            {
                min = 0;
                max = 4;
            }
            else
            {
                min = 0;
                max = 100;
            }
            int[] array = new int[N]; 
            Random rnd = new Random(Guid.NewGuid().GetHashCode()); //эту часть посмотрел в интернете, как получить случайное число.
            // Изначально хотел через DateTime.Now.Millisecond, но бывали ситуации когда выполнялось слишком быстром и генерировались одинаковые числа
            for (int i = 0; i < N; i++)
            {
                array[i] = rnd.Next(min, max);
            }
            return array;
        }

        public static void ArrayPrint(int[] array, string name)
        {
            Console.WriteLine($"{name}:");
            
            int counter = 1;
            foreach (var VARIABLE in array)
            {
                Console.WriteLine($"{counter}: {VARIABLE}");
                counter += 1;
            }
            Console.WriteLine();
        }
    }
}