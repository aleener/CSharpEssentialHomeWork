using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_4_Task2
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC is opened");
        }
        public override void Create()
        {
            Console.WriteLine("DOC is created");
        }
        public override void Change()
        {
            Console.WriteLine("DOC is changed");
        }
        public override void Save()
        {
            Console.WriteLine("DOC is saved");
        }
    }
}
