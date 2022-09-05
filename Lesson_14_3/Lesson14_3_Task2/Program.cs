using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task2
{
    //Требуется: Создать класс, представляющий учебный класс ClassRoom.

    //Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
    
    //Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil
    //и переопределите каждый из методов, в зависимости от успеваемости ученика.
    
    //Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
    
    //Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
    
    //Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать. 
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil pupil1 = new ExcelentPupil();
            GoodPupil pupil2 = new GoodPupil();
            BadPupil pupil3 = new BadPupil();
            ExcelentPupil pupil4 = new ExcelentPupil();
            
               
            ClassRoom classRoom1 = new ClassRoom(pupil1);
            ClassRoom classRoom2 = new ClassRoom(pupil1,pupil3,pupil2,pupil4);
            ClassRoom classRoom3 = new ClassRoom(pupil3,pupil2,pupil1);
            ClassRoom classRoom4 = new ClassRoom(pupil2,pupil3);

            Console.WriteLine($"{new string('-', 30)}\n\t{nameof(classRoom1)}\n{new string ('-',30)}");
            classRoom1.Show();

            Console.WriteLine($"{new string('-', 30)}\n\t{nameof(classRoom2)}\n{new string('-', 30)}");
            classRoom2.Show();

            Console.WriteLine($"{new string('-', 30)}\n\t{nameof(classRoom3)}\n{new string('-', 30)}");
            classRoom3.Show();

            Console.WriteLine($"{new string('-', 30)}\n\t{nameof(classRoom4)}\n{new string('-', 30)}");
            classRoom4.Show();

            Console.ReadKey();
        }
    }
}
