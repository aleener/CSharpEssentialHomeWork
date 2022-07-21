using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task3
{
    internal class Ship : Vehicle
    {
        string port { get; set; }
        uint passengers { get; set; }
        public Ship(double x, double y, double price, double speed, ushort year, string port, uint passengers) : base(x, y, price, speed, year) 
        { 
            this.passengers = passengers;
            this.port = port;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Number of passengers:\t{passengers}\nRegistration port:\t{port}");
        }
    }
}
