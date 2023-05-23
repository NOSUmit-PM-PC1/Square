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
            List<Point> nAngle = new List<Point>()
            {
               new Point(1, 2), new Point(3, 4), new Point(2, 2), new Point(3, 0)
            };

            nAngle.Add(nAngle[0]);
            List<Trapezoid> t = new List<Trapezoid>();
            for (int i = 0; i < nAngle.Count - 1; i++)
            {
                t.Add(new Trapezoid(nAngle[i], nAngle[i + 1]));
            }
            int s = 0;
            foreach (var tr in t)
            {
                s += tr.SignDoubleSquare();
            }
            Console.WriteLine(s);
            List<Point> nAngle = new List<Point>()
            {
               // new Point(0, 0), new Point(4, 3), new Point(8, 1),
               // new Point(7, -3), new Point(2, -5)
               new Point(0, 0), new Point(0, 4), new Point(5, 4), new Point(5, 0), new Point(0, 3)
            };

            List<Triangle> listTriangles = new List<Triangle>();
            for (int i = 0; i < nAngle.Count - 2; i++)
            {
                listTriangles.Add(new Triangle(nAngle[0], nAngle[i + 1], nAngle[i + 2]));
            }

            double s = 0;
            foreach (var triangle in listTriangles)
                s += triangle.Square();
            Console.WriteLine(s);
            
        }
    }
}
