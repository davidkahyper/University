namespace Program
{
    class Rational
    {
        public int top
        {
            get
            {
                return top;
            }
            private set
            {
                top = value;
            }
        }

        public int down
        {
            get
            {
                return down;
            }
            private set
            {
                down = value;
            }
        }
        private const string NONE_EXIST = "Ошибка! 0 в знаменателе";

        public Rational(int top, int down)  
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

        public Rational()
        {
            top = 0;
            down = 1;
        }

        public static int FindNod(int t, int d)
        {
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
    }
}