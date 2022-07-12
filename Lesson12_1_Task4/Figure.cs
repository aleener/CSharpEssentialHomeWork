using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_Task4
{
    internal class Figure
    {
        private Point point1, point2, point3, point4, point5;
        private string name;
        public string Name { get { return name; }}
        public Point Point1 { get { return point1; }}
        public Point Point2 { get { return point2; }}
        public Point Point3 { get { return point3; }}
        public Point Point4 { get { return point4; }}
        public Point Point5 { get { return point5; }}


        public Figure(Point a, Point b, Point c)
        {
            this.name = "triangle";
            this.point1 = a;
            this.point2 = b;
            this.point3 = c;
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            this.name = "quadrangle";
            this.point1 = a;
            this.point2 = b;
            this.point3 = c;
            this.point4 = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            this.name = "pentagon";
            this.point1 = a;
            this.point2 = b;
            this.point3 = c;
            this.point4 = d;
            this.point5 = e;
        }

    }
      
}
