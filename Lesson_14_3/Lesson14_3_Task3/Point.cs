using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task3
{
    internal class Point
    {
        private double x, y;
        public double X { get { return x; } set { this.X = x; } }
        public double Y { get { return y; } set { this.Y = y; } }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            Console.WriteLine($"{this.x} , {this.y}");
        }
    }
}
