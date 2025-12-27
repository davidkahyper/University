using System.Drawing;

namespace Laba3
{
    public class Testing 
    {
        public static void HelpTestLineD(LineD line1, LineD line2)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Line1: ");
            line1.Print();
            Console.WriteLine(line1.ToString());
            Console.WriteLine();
            Console.WriteLine("Line2: ");
            line2.Print();
            Console.WriteLine(line2.ToString());
            
            Console.WriteLine();
            Console.Write("Intersection: ");
            Console.WriteLine(LineD.FindIntersection(line1, line2).ToString());
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("\n\n\n");
        }
        public static void TestLineD()
        {
            LineD line1 = new LineD(1, 1, 2, 2);
            LineD line2 = new LineD(2, 4, 4, 8);
            HelpTestLineD(line1, line2);
            
            line1 = new LineD(0, 0, 1, 1);
            line2 = new LineD(0, 1, 1, 0);
            HelpTestLineD(line1, line2);
            
            line1 = new LineD(1, 2, 3, 6);
            line2 = new LineD(0, 4, 2, 0);
            HelpTestLineD(line1, line2);
            
            line1 = new LineD(0, 0, 1, 0.5);
            line2 = new LineD(0, 1, 1, 0.5);
            HelpTestLineD(line1, line2);
            
            line1 = new LineD(-1, -2, 0, -1);
            line2 = new LineD(-2, -1, 0, -3);
            HelpTestLineD(line1, line2);
            
            line1 = new LineD(0, 0, 1, 1);
            line2 = new LineD(0, 1, 1, 2);
            HelpTestLineD(line1, line2);
        }

        public static void TestPointD()
        {
            PointD point1 = new PointD(0, 1);
            PointD point2 = new PointD(0, 1);
            
            Console.Write("точки одинаковы?: ");
            Console.WriteLine(point1 == point2);
            Console.WriteLine();
            
            point1 = new PointD(0, 1);
            point2 = new PointD(5, 1);
            
            Console.Write("точки одинаковы?: ");
            Console.WriteLine(point1 == point2);
            Console.WriteLine();
            
            PointD point = new PointD(5);
            Console.WriteLine(point.ToString() + "\n");
            
            point = new PointD(4, 5);
            point.MoveX(12);
            Console.WriteLine(point.ToString() + "\n");
            
            point = new PointD(4, 5);
            point.MoveY(12);
            Console.WriteLine(point.ToString() + "\n");
            
            point = new PointD(4, 5);
            point.MoveR(12);
            Console.WriteLine(point.ToString() + "\n");
            
            point = new PointD( 16.76, 0.3, "12312331");
            Console.WriteLine(point.ToString() + "\n");
            
            
            point = new PointD( 16.76, 0.3, "12312331");
            point.MoveFI(-3);
            Console.WriteLine(point.ToString() + "\n");
            
            
            point = new PointD( 16.76, 0.3, "12312331");
            point.MoveR(-123);
            Console.WriteLine(point.ToString() + "\n");
        }
    }
}