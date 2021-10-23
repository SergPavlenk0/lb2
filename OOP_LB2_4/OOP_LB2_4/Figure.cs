using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LB2_4
{
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
}

