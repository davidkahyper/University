using System.Security.Cryptography;

namespace Program
{
    class Rational
    {
        public int top { get; private set; }
        public int down { get; private set; }
        private const string NONE_EXIST = "Ошибка! 0 в знаменателе";

        public Rational(int top, int down)  
        {
            if (down == 0) throw new RationalException(NONE_EXIST);

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

        public Rational()
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

        public Rational Plus(Rational num)
        {
            return new Rational(top*num.down + down*num.top, down*num.down);
        }

        public static Rational operator+(Rational r1, Rational r2)
        {
            return r1.Plus(r2);
        }
        
        public Rational Minus(Rational num)
        {
            return new Rational(top*num.down - down*num.top, down*num.down);
        }
        
        public static Rational operator-(Rational r1, Rational r2)
        {
            return r1.Minus(r2);
        }
        
        public Rational Mult(Rational num)
        {
            return new Rational(top*num.top, down*num.down);
        }
        
        public static Rational operator*(Rational r1, Rational r2)
        {
            return r1.Mult(r2);
        }
        
        public Rational Divide(Rational num)
        {
            return new Rational(top*num.down, down*num.top);
        }
        
        public static Rational operator/(Rational r1, Rational r2)
        {
            return r1.Divide(r2);
        }
    }
}