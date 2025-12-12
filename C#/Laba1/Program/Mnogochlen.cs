


using System.Diagnostics;

namespace Program
{
    public enum DiscriminantEnum
    {
        ZeroCorney,
        OneCoreney,
        TwoCoreney
    }

    
    class Mnogochlen
    {
        
        
        // ax^2 + bx + c
        private int a, b, c;
        public double discriminant { get; private set;}
        private DiscriminantEnum discriminantState;
        
        public Mnogochlen(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            
            discriminant = Discriminant();
            discriminantState = DiscriminantState();
        }

        public override string ToString()
        {
            string temp = "";
            
            if (a == 0) ;
            else temp = $"{a}x^2";
            
            if (b > 0) temp += $" + {b}x";
            if (b < 0) temp += $" - {Math.Abs(b)}x";
            if (b == 0) ;
            
            if (c > 0) temp += $" + {c}";
            if (c < 0) temp += $" - {Math.Abs(c)}";
            if (c == 0) ;

            return temp;
        }

        private double Discriminant()
        {
            return b * b - 4 * a * c;
        }

        private DiscriminantEnum DiscriminantState()
        {
            if (discriminant > 0)
            {
                return DiscriminantEnum.TwoCoreney;
            }
        
            if (discriminant == 0)
            {
                return DiscriminantEnum.OneCoreney;
            }

            if (discriminant < 0)
            {
                return DiscriminantEnum.ZeroCorney;
            }

            Console.WriteLine("ОШИБКА! ЧТО-ТО НЕ ТАК С ДИСКРИМИНАНТОМ");
            throw new Exception();
        }

        public void PrintKolvoCorney()
        {
            Console.WriteLine($"Дискриминант: {discriminant}");
            Console.WriteLine($"Кол-во корней: {(int) discriminantState}");
        }
        
        
    }
}