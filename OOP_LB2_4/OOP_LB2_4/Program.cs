using System;

namespace OOP_LB2_4
{
    class Point
    {
        public int Int1 { get; }
        public int Int2 { get; }
        public string Str1 { get; }
        public Point(int int1, int int2, string str1 = "")
        {
            Int1 = int1;
            Int2 = int2;
            Str1 = str1;
        }
    }
    class Figure
    {
        private double side1, side2, side3, side4, side5;
        //Треугольник
        public Figure(Point a, Point b, Point c)
        {
            side1 = LengthSide(a, b);
            side2 = LengthSide(b, c);
            side3 = LengthSide(c, a);
        }
        //четырёхугольник
        public Figure(Point a, Point b, Point c, Point d)
        {
            side1 = LengthSide(a, b);
            side2 = LengthSide(b, c);
            side3 = LengthSide(c, d);
            side4 = LengthSide(d, a);
        }
        //пятиугольник
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            side1 = LengthSide(a, b);
            side2 = LengthSide(b, c);
            side3 = LengthSide(c, d);
            side4 = LengthSide(d, e);
            side5 = LengthSide(e, a);
        }
        public static double LengthSide(Point a, Point b)
        {
            return Math.Abs(Math.Sqrt(Math.Pow(a.Int1 - b.Int1, 2) + Math.Pow(a.Int2 - b.Int2, 2)));
        }
        public void PerimeterCalculator()
        {
            if (side5 != 0)
            {
                double perimeter = side1 + side2 + side3 + side4 + side5;
                Console.WriteLine(perimeter);
            }
            else if (side5 == 0 & side4 != 0)
            {
                double perimeter = side1 + side2 + side3 + side4;
                Console.WriteLine(perimeter);
            }
            else
            {
                double perimeter = side1 + side2 + side3;
                Console.WriteLine(perimeter);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(9, 6);
            Point point2 = new Point(8, 7);
            Point point3 = new Point(4, 3);
            Point point4 = new Point(5, 2);

            Figure figure = new Figure(point1, point2, point3, point4);
            figure.PerimeterCalculator();
        }
    }
}
