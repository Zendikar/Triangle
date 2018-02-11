using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Triangle t1 = new Triangle(3,3,3);
            Triangle t2 = new Triangle(4,4,2);
            Triangle t3 = new Triangle(0, 4, 2);
            Triangle t4 = new Triangle(1, 4, 2);

            Console.WriteLine(new TriangleController(t1));
            Console.WriteLine(new TriangleController(t2));
            Console.WriteLine(new TriangleController(t3));
            Console.WriteLine(new TriangleController(t4));
            Console.WriteLine(new TriangleController(null));

        }
    }
}
