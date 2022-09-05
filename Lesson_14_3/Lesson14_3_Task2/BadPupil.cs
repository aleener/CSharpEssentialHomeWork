using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task2
{
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study Bad");
        }
        public override void Read()
        {
            Console.WriteLine("Read Bad");
        }
        public override void Write()
        {
            Console.WriteLine("Write Bad");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax Bad");
        }
    }
}
