using System.Diagnostics;

namespace Program
{
    class Test
    {
        public static void TestCreateRational()
        {
            // try
            // {
                Rational t1 = new Rational(2, 3);
                Rational t2 = new Rational(10, 5);
                Rational t3 = new Rational(5, 10);
                Rational t4 = new Rational(3, 2);

                Console.WriteLine(t1.ToString());
                Console.WriteLine(t2.ToString());
                Console.WriteLine(t3.ToString());
                Console.WriteLine(t4.ToString());
            // }
            // catch (RationalException e)
            // {
            //     Console.WriteLine(e.Message);
            // }
        }

        public static void TestPlusRational()
        {
            Rational t1 = new Rational(2, 3);
            Rational t2 = new Rational(10, 5);

            // var t3 = t1.Plus(t2);
            var t3 = t1 + t2;
            Console.WriteLine(t3.ToString());
        }
        
        public static void TestOperationsRational()
        {
            Rational t1 = new Rational(2, 3);
            Rational t2 = new Rational(10, 5);

            // var t3 = t1.Plus(t2);
            var t3 = t1 + t2;
            Console.WriteLine(t3.ToString());
            
            t3 = t1 - t2;
            Console.WriteLine(t3.ToString());
            
            t3 = t1 * t2;
            Console.WriteLine(t3.ToString());
            
            t3 = t1 / t2;
            Console.WriteLine(t3.ToString());
        }

        public static void TestOperationsComplex()
        {
            // Complex firstNum = new Complex(-1, 3);
            // Complex secondNum = new Complex(6, -9);
            Complex firstNum = new Complex(3, 2);
            Complex secondNum = new Complex(1, 4);

            Console.WriteLine(firstNum.ToString());
            Console.WriteLine(secondNum.ToString());
            Console.WriteLine("\n\n\n");

            Complex test = Complex.MultComplexNumbers(firstNum, secondNum);
            Console.WriteLine(test);
            Console.WriteLine("\n\n\n");
            
            test = firstNum * secondNum;
            Console.WriteLine(firstNum);
        }

        public static void TestOperationsMnogochlen()
        {
            Mnogochlen firstNum = new Mnogochlen(2, -31, 4);
            Console.WriteLine(firstNum.ToString());
            firstNum.PrintKolvoCorney();
        }
    }
}