using System;

namespace OOP_LB2_4
{
    
    
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
