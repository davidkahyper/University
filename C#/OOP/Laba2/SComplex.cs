namespace Laba2
{
    struct SComplex
    {
        // z = a + bi
        private int a;
        private int b;

        public SComplex(int a, int b)
        {
            this.a = a;

            if (b == 0)
            {
                Console.WriteLine("Ошибка! Комплексная часть не может быть равна 0!");
                this.b = 1;
            }
            else this.b = b;
        }

        public SComplex()
        {
            this.a = 0;
            this.b = 1;
        }

        public override string ToString()
        {
            if (b < 0) return $"{a} - {Math.Abs(b)}i";

            return $"{a} + {b}i";
        }


        public static SComplex AddComplexNumbers(SComplex firstNumber, SComplex secondNumber)
        {
            SComplex newNumber = new SComplex();
            newNumber.a = firstNumber.a + secondNumber.a;
            newNumber.b = firstNumber.b + secondNumber.b;

            return newNumber;
        }

        public static SComplex MinusComplexNumbers(SComplex firstNumber, SComplex secondNumber)
        {
            SComplex newNumber = new SComplex();
            newNumber.a = firstNumber.a - secondNumber.a;
            newNumber.b = firstNumber.b - secondNumber.b;

            return newNumber;
        }

        public static SComplex MultComplexNumbers(SComplex firstNumber, SComplex secondNumber)
        {
            SComplex newNumber = new SComplex();
            newNumber.a = firstNumber.a * secondNumber.a + firstNumber.b * secondNumber.b * (-1);
            newNumber.b = firstNumber.a * secondNumber.b + firstNumber.b * secondNumber.a;

            return newNumber;
        }

        public static SComplex operator +(SComplex complex1, SComplex complex2)
        {
            return SComplex.AddComplexNumbers(complex1, complex2);
        }

        public static SComplex operator -(SComplex complex1, SComplex complex2)
        {
            return SComplex.MinusComplexNumbers(complex1, complex2);
        }

        public static SComplex operator *(SComplex complex1, SComplex complex2)
        {
            return SComplex.MultComplexNumbers(complex1, complex2);
        }
    }
}