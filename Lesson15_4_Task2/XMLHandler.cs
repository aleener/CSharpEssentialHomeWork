using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_4_Task2
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML is opened");
        }
        public override void Create()
        {
            Console.WriteLine("XML is created");
        }
        public override void Change()
        {
            Console.WriteLine("XML is changed");
        }
        public override void Save()
        {
            Console.WriteLine("XML is saved");
        }
    }
}
