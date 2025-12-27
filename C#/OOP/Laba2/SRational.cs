namespace Laba2
{
    struct SRational
    {
        public int top { get; private set; }
        public int down { get; private set; }
        private const string NONE_EXIST = "Ошибка! 0 в знаменателе";

        public SRational(int top, int down)  
        {
            // if (down == 0) throw new RationalException(NONE_EXIST);

            if (down < 0)
            {
                top *= -1;
                down *= -1; 
            }
            
            int nod = FindNod(top, down);
            // System.Console.WriteLine($"До сокращения: t: {top}, d: {down}");
            this.top = top / nod;
            this.down = down / nod;
            // System.Console.WriteLine($"После сокращения: t: {this.top}, d: {this.down}\n\n");
        }

        public SRational()
        {
            top = 0;
            down = 1;
        }

        public static int FindNod(int t, int d)
        {
            t = Math.Abs(t);
            d = Math.Abs(d);
            
            int temp = 0;
            do
            {
                temp = t % d;
                t = d;
                d = temp;
            } while (d != 0);

            return t;
        }

        public override string ToString()
        {
            return $"{top}/{down}";
        }

        public SRational Plus(SRational num)
        {
            return new SRational(top*num.down + down*num.top, down*num.down);
        }

        public static SRational operator+(SRational r1, SRational r2)
        {
            return r1.Plus(r2);
        }
        
        public SRational Minus(SRational num)
        {
            return new SRational(top*num.down - down*num.top, down*num.down);
        }
        
        public static SRational operator-(SRational r1, SRational r2)
        {
            return r1.Minus(r2);
        }
        
        public SRational Mult(SRational num)
        {
            return new SRational(top*num.top, down*num.down);
        }
        
        public static SRational operator*(SRational r1, SRational r2)
        {
            return r1.Mult(r2);
        }
        
        public SRational Divide(SRational num)
        {
            return new SRational(top*num.down, down*num.top);
        }
        
        public static SRational operator/(SRational r1, SRational r2)
        {
            return r1.Divide(r2);
        }
    }
}