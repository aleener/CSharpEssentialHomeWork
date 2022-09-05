using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task2
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study Excelent");
        }
        public override void Read()
        {
            Console.WriteLine("Read Excelent");
        }
        public override void Write()
        {
            Console.WriteLine("Write Excelent");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax Excelent");
        }
    }
}
