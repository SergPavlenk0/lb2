using System;
using System.Collections.Generic;
using System.Text;

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
}
