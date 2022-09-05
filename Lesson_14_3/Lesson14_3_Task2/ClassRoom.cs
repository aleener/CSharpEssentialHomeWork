using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task2
{
    internal class ClassRoom
    {
        Pupil pupil1;
        Pupil pupil2;
        Pupil pupil3;
        Pupil pupil4;

        public ClassRoom(Pupil pupil1)
        {
            this.pupil1 = pupil1;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            this.pupil4 = pupil4;
        }
        public void Show()
        {
            if (this.pupil1 != null && this.pupil2 != null && this.pupil3 != null && this.pupil4 != null)
            {
                Console.WriteLine($"{nameof(pupil1)}:");
                pupil1.Study(); pupil1.Read(); pupil1.Write(); pupil1.Relax();
                Console.WriteLine();
                Console.WriteLine($"{nameof(pupil2)}:");
                pupil2.Study(); pupil2.Read(); pupil2.Write(); pupil2.Relax();
                Console.WriteLine();
                Console.WriteLine($"{nameof(pupil3)}:");
                pupil3.Study(); pupil3.Read(); pupil3.Write(); pupil3.Relax();
                Console.WriteLine();
                Console.WriteLine($"{nameof(pupil4)}:");
                pupil4.Study(); pupil4.Read(); pupil4.Write(); pupil4.Relax();
                Console.WriteLine();
            }
            else if (this.pupil1 != null && this.pupil2 != null && this.pupil3 != null)
            {
                Console.WriteLine($"{nameof(pupil1)}:");
                pupil1.Study(); pupil1.Read(); pupil1.Write(); pupil1.Relax();
                Console.WriteLine();
                Console.WriteLine($"{nameof(pupil2)}:");
                pupil2.Study(); pupil2.Read(); pupil2.Write(); pupil2.Relax();
                Console.WriteLine();
                Console.WriteLine($"{nameof(pupil3)}:");
                pupil3.Study(); pupil3.Read(); pupil3.Write(); pupil3.Relax();
                Console.WriteLine();
            }
            else if (this.pupil1 != null && this.pupil2 != null)
            {
                Console.WriteLine($"{nameof(pupil1)}:");
                pupil1.Study(); pupil1.Read(); pupil1.Write(); pupil1.Relax();
                Console.WriteLine();
                Console.WriteLine($"{nameof(pupil2)}:");
                pupil2.Study(); pupil2.Read(); pupil2.Write(); pupil2.Relax();
                Console.WriteLine();
            }
            else if (this.pupil1 != null)
            {
                Console.WriteLine($"{nameof(pupil1)}:");
                pupil1.Study(); pupil1.Read(); pupil1.Write(); pupil1.Relax();
                Console.WriteLine();
            }
        }

    }
}
