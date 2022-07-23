using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task5
{
    internal class YellowPrint : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Print(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
