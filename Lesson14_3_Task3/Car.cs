using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task3
{
    internal class Car : Vehicle
    {
        public Car(double x, double y, double price, double speed, ushort year) : base(x, y, price, speed, year) { }
    }
}
