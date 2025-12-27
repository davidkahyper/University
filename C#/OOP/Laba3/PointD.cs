using System.Diagnostics;

namespace Laba3
{
    public struct PointD
    {
        private const double EPS = 1.0E-7;
        private const string ERR_MESSAGE = "Ошибка! r < 0. Замена r на |r|";

        private double x, y;
        private double r, fi;


        /// <summary>
        /// Декартов конструктор
        /// </summary>
        /// <param name="x">горизонтальная координата по оси x</param>
        /// <param name="y">вертикальная координата по оси y</param>
        public PointD(double x, double y)
        {
            this.x = x;
            this.y = y;

            r = Math.Sqrt(x * x + y * y);
            fi = Math.Atan2(y, x);
        }



        /// <summary>
        /// Полярный конструктор
        ///  r, fi - полярные координаты
        /// </summary>

        /// <param name="r">радиус</param>
        /// <param name="fi">угол fi</param>
        /// <param name="tip">можно указать любой тип</param>
        public PointD(double r, double fi, string tip)
        {
            try
            {
                if (r < 0) throw (new PointDException(ERR_MESSAGE));
                this.r = r;
                this.fi = fi;
                x = r * Math.Cos(fi);
                y = r * Math.Sin(fi);
            }
            catch (ArithmeticException e)
            {
                Debug.WriteLine(e.Message);
                r = -r;
                this.r = r;
                this.fi = fi;
                x = r * Math.Cos(fi);
                y = r * Math.Sin(fi);
            }
        }

        /// <summary>
        /// Random конструктор
        /// создает точку со случайными вещественными координатами 
        /// в пределах окружности заданного радиуса MaxR
        /// </summary>
        /// <param name="MaxR">радиус окружности</param>
        public PointD(double MaxR)
        {
            Random rnd = new Random();

            r = rnd.NextDouble() * MaxR;
            fi = rnd.NextDouble() * Math.PI * 2;
            x = r * Math.Cos(fi);
            y = r * Math.Sin(fi);
        }

        /// <summary>
        /// Random конструктор
        /// создает точку со случайными целочисленными
        /// декартовыми координатами 
        /// в пределах квадрата со стороной Max
        /// </summary>
        /// <param name="MaxR">радиус окружности</param>
        public PointD(int Max)
        {
            Random rnd = new Random();

            x = rnd.Next(Max);
            y = rnd.Next(Max);
            r = Math.Sqrt(x * x + y * y);
            fi = Math.Atan2(y, x);
        }

        /// <summary>
        /// Конструктор копии
        /// </summary>
        /// <param name="p">копируемая точка</param>
        public PointD(PointD pt)
        {
            this = pt;
        }

        //Процедуры-свойства

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public double R
        {
            get { return r; }
        }

        public double FI
        {
            get { return fi; }
        }

        public override bool Equals(object point1)
        {
            if (point1.GetType() != typeof(PointD)) return false;

            PointD p = (PointD)point1;

            return (Math.Abs(this.x - p.x) < EPS) && (Math.Abs(this.y - p.y) < EPS);
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(r + fi);
        }

        public override string ToString()
        {
            string s = "x = {0}, y = {1}, r = {2}, fi = {3}";
            s = string.Format(s, x, y, r, fi);
            return s;
        }

        /// <summary>
        /// переместить точку по горизонтали
        /// </summary>
        /// <param name="dx">смещение по оси x</param>        
        public void MoveX(double dx)
        {
            x += dx;
            FromDecartToPolar();
        }

        /// <summary>
        /// переместить точку по вертикали
        /// </summary>
        /// <param name="dy">смещение по оси y</param>
        public void MoveY(double dy)
        {
            y += dy;
            FromDecartToPolar();
        }

        /// <summary>
        /// переместить точку по радиусу
        /// </summary>
        /// <param name="dr">Растяжение (dr > 1) или 
        /// сжатие (dr < 1) по радиусу</param>
        public void MoveR(double dr)
        {
            r *= dr;
            FromPolarToDecart();
        }

        /// <summary>
        /// повернуть точку по окружности
        /// </summary>
        /// <param name="dfi">поворот против часовой стрелки</param>
        public void MoveFI(double dfi)
        {
            fi += dfi;
            while (fi > Math.PI) fi -= 2 * Math.PI;
            while (fi < -Math.PI) fi += 2 * Math.PI;

            FromPolarToDecart();
        }

        public static bool operator ==(PointD p1, PointD p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(PointD p1, PointD p2)
        {
            return !p1.Equals(p2);
        }

        void FromDecartToPolar()
        {
            r = Math.Sqrt(x * x + y * y);
            fi = Math.Atan2(y, x);
        }

        void FromPolarToDecart()
        {
            x = r * Math.Cos(fi);
            y = r * Math.Sin(fi);
        }
    }

    public class PointDException : Exception
    {
        public PointDException()
        {
        }

        public PointDException(string message) : base(message)
        {
        }

        public PointDException(string message, Exception e) : base(message, e)
        {
        }
    }
}