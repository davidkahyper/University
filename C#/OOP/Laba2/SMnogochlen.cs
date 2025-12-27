namespace Laba2
{
    public enum DiscriminantEnum
    {
        ZeroCorney,
        OneCoreney,
        TwoCoreney
    }

    
    struct SMnogochlen
    {
        
        
        // ax^2 + bx + c
        private int a, b, c;
        public double discriminant { get; private set;}

        private double x1;
        public double X1
        {
            get
            {
                if (discriminantState == DiscriminantEnum.ZeroCorney)
                {
                    throw new NotImplementedException();
                }
                return x1;
            }
            private set
            {
                x1 = value;
            }
        }
        
        private double x2;
        public double X2
        {
            get
            {
                if (discriminantState == DiscriminantEnum.ZeroCorney || discriminantState == DiscriminantEnum.OneCoreney)
                {
                    throw new NotImplementedException();
                }
                return x2;
            }
            private set
            {
                x2 = value;
            }
        }
        
        private DiscriminantEnum discriminantState;
        
        public SMnogochlen(int a, int b, int c)
        {
            if (a == 0) throw new ArgumentException();
            
            this.a = a;
            this.b = b;
            this.c = c;
            
            discriminant = Discriminant();
            discriminantState = DiscriminantState();

            GetKorni();
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

        private void GetKorni()
        {
            if (discriminantState == DiscriminantEnum.TwoCoreney)
            {
                x1 = Math.Round((-b + Math.Pow(discriminant, 0.5)) / (2 * a), 2);
                x2 = Math.Round((-b - Math.Pow(discriminant, 0.5)) / (2 * a), 2);
            }
            else if (discriminantState == DiscriminantEnum.OneCoreney)
            {
                x1 = Math.Round((-b + 0.0)/(2 * a), 2);
                x2 = x1;
            }
            else if (discriminantState == DiscriminantEnum.ZeroCorney)
            {
                x1 = 0;
                x2 = 0;
            }
        }

        public DiscriminantEnum GetCountCorney()
        {
            return discriminantState;
        }
    }
}