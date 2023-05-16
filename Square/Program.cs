using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(5, 6);
            Point b = new Point(10, 1);
            Point c = new Point(1, -10);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());

            Vector ab = new Vector(a, b);
            Console.WriteLine(ab.ToString());
            Console.WriteLine(ab.Length());

            Triangle abc = new Triangle(a, b, c);
            Console.WriteLine(abc.Square());

            Triangle bac = new Triangle(c, a, b);
            Console.WriteLine(bac.Square());

            Triangle newTri = new Triangle(new Point(0, 0), new Point(0, 4), new Point(5, 0));
            Console.WriteLine(newTri.Square());
        }
    }
}
