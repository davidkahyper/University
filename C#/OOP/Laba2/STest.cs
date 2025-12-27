namespace Laba2
{
    class STest
    {
        public static void TestOperationsSRational()
        {
            SRational t1 = new SRational(2, 3);
            SRational t2 = new SRational(10, 5);

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
        public static void TestOperationsSComplex()
        {
            // Complex firstNum = new Complex(-1, 3);
            // Complex secondNum = new Complex(6, -9);
            SComplex firstNum = new SComplex(3, 2);
            SComplex secondNum = new SComplex(1, 4);

            Console.WriteLine(firstNum.ToString());
            Console.WriteLine(secondNum.ToString());
            Console.WriteLine("\n\n\n");

            SComplex test = SComplex.MultComplexNumbers(firstNum, secondNum);
            Console.WriteLine(test);
            Console.WriteLine("\n\n\n");
            
            test = firstNum * secondNum;
            Console.WriteLine(firstNum);
        }

        public static void TestOperationsSMnogochlen()
        {
            // Mnogochlen firstNum = new Mnogochlen(-4, 5, 78);
            // Mnogochlen firstNum = new Mnogochlen(-1, -1, -2);
            SMnogochlen firstNum = new SMnogochlen(1, 0, -10);
            Console.WriteLine(firstNum.ToString());
        
            if (firstNum.GetCountCorney() == DiscriminantEnum.TwoCoreney)
            {
                Console.WriteLine($"{firstNum.X1}  {firstNum.X2}\n\n\n");
            }
            else if (firstNum.GetCountCorney() == DiscriminantEnum.OneCoreney)
            {
                Console.WriteLine($"{firstNum.X1}\n\n\n");
                Console.WriteLine($"{firstNum.X2}\n\n\n");
            }
            else Console.WriteLine("Корней 0! \n\n\n");
        }
    }
}