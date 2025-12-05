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
    }
}