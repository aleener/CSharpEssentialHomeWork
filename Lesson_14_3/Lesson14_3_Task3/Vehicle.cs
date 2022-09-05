using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task3
{
    internal class Vehicle
    {
        Point coordinates { get; set; }
        double price { get; set; }
        double speed { get; set; }
        ushort year { get; set; }

        public Vehicle(double x, double y, double price, double speed, ushort year)
        {
            this.coordinates = new Point(x,y);
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Coordinates:\t\t{coordinates.X} : {coordinates.Y}\nPrice:\t\t\t\u0024 {price}\nSpeed:\t\t\t{speed} mph\nYear of release:\t{year}");
        }
    }
}
