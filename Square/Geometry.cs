using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Geometry
    {

    }

    class Point
    {
        public int x, y;
        public Point(int userX, int userY)
        {
            x = userX;
            y = userY;
        }

        public string ToString()
        { 
            return  $"({x},{y})";       
        }
    }

    class Vector
    {
        public Point pointBegin, pointEnd;
        Point koor;
        public Vector(Point userPointBegin, Point userPointEnd)
        {
            pointBegin = userPointBegin;
            pointEnd = userPointEnd;
            koor = new Point(pointEnd.x - pointBegin.x, pointEnd.y - pointBegin.y);
        }

        public string ToString()
        {
            return $"({koor.x};{koor.y})";
        }

        public double Length()
        {
            return Math.Sqrt(koor.x * koor.x + koor.y * koor.y);
        }
        //псевдо векторное или косое векторное произведение
        public int CroossProdact(Vector b)
        {
            return this.koor.x * b.koor.y - this.koor.y * b.koor.x;
        }
    }

    class Triangle
    {
        Point A, B, C;
        public Triangle(Point userA, Point userB, Point userC)
        {
            A = userA; B = userB; C = userC;
        }

        public double Square()
        {
            Vector ab = new Vector(A, B);
            Vector ac = new Vector(A, C);
            return Math.Abs(ab.CroossProdact(ac)) / 2.0;
        }

    }

    class Trapezoid
    {
        Vector vector;

        public Trapezoid(Vector userVector)
        {
            vector = userVector;
        }

        public Trapezoid(Point userPoint1, Point userPoint2)
        {
            vector = new Vector(userPoint1, userPoint2);
        }

        public int SignDoubleSquare()
        {
            return (vector.pointBegin.y + vector.pointEnd.y) * (vector.pointEnd.x - vector.pointBegin.x);
        }
    }
}
