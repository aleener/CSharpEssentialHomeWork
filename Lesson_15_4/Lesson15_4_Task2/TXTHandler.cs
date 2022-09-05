using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_4_Task2
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT is opened");
        }
        public override void Create()
        {
            Console.WriteLine("TXT is created");
        }
        public override void Change()
        {
            Console.WriteLine("TXT is changed");
        }
        public override void Save()
        {
            Console.WriteLine("TXT is saved");
        }
    }
}
