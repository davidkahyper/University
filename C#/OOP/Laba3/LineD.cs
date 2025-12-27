namespace Laba3
{
    public class LineD
    {
        private double x1, y1, x2, y2, k, c;
        private const double EPS = 1.0E-7;

        public LineD()
        {
            x1 = 0;
            x2 = 0;
            y1 = 0;
            y2 = 0;
            k = 0;
        }

        public LineD(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;

            k = CalculateK();
            c = CalculateC();
        }

        public static bool CheckParralel(LineD firstLine, LineD secondLine)
        {
            if (Math.Abs(firstLine.k - secondLine.k) < EPS)
            {
                return true;
            }

            return false;
        }

        private double CalculateK()
        {
            return Math.Round((y2 - y1) / (x2 - x1), 3);
        }

        private double CalculateC()
        {
            return Math.Round(y1 - k * x1, 3);
        }

        public static PointD FindIntersection(LineD line1, LineD line2)
        {
            if (CheckParralel(line1, line2)) throw new Exception("Линии одинаковы/паралелльны");
                
            double x, y;
            x = Math.Round((line2.c - line1.c) / (line1.k - line2.k), 2);
            y = Math.Round(line1.k * x + line1.c, 2);


            if (x == -0) x = 0;
            if (y == 0)  y = 0;
            return new PointD(x, y);
        }

        public void Print()
        {
            Console.WriteLine($"{x1}, {y1}, {x2}, {y2}");
            Console.WriteLine($"k: {k}");
            Console.WriteLine($"c: {c}");
        }

        public override string ToString()
        {
            if (c > 0) return $"y = {k}k + {c}";
            return $"y = {k}k - {Math.Abs(c)}";
        }
    }
}