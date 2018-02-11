using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class TriangleController
    {
        private Triangle t;
        public static String type1 = "This is an equilateral triangle";
        public static String type2 = "This is an isosceles triangle";
        public static String type3 = "This is a scalene triangle";

        public TriangleController(Triangle t)
        {
            this.t = t;
        }

        public String testTriangle()
        {
            if (t == null)
            {
                return ("The triangle cannot be null");
            }
            if (t.Length1 <= 0 || t.Length2 <= 0 || t.Length3 <= 0)
            {
                return("This is not a valid triangle");
            }
            if (t.Length1 == t.Length3 && t.Length1 == t.Length2)
                {
                    return type1;
                } 
            else if (t.Length1==t.Length2 || t.Length2==t.Length3 || t.Length1==t.Length3)
            {
                return type2;
            }
            else
            {
                return type3;
            }
        }

        public override string ToString()
        {
            return testTriangle();
        }
    }
}
