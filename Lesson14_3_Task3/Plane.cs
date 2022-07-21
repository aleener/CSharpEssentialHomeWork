using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task3
{
    internal class Plane : Vehicle
    {
        double altitude { get; set; }
        ushort passengers { get; set; }
        public Plane(double x, double y, double price, double speed, ushort year, double altitude, ushort passengers) : base(x, y, price, speed, year)
        {
            this.altitude = altitude;
            this.passengers = passengers;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Flight altitude:\t{altitude} ft\nNumber of passengers:\t{passengers}");
        }
    }
}
