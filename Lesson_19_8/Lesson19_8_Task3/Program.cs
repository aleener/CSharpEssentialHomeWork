using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_8_Task3
{
    //Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
    //Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц.
    //Создайте класс Accountant с методом bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику премию.
    //Если сотрудник отработал больше положенных часов в месяц, то ему положена премия.

    static class Accountant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
            {
                return true;
            }
            return false;
        }
    }
    enum Post
    {
        Specialist = 40,
        MainSpecialsit = 50,
        Manager = 60,
        Director = 100
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Post worker = Post.Manager;
            if (Accountant.AskForBonus(worker, 65))
            {
                Console.WriteLine("BONUS +");
            }
            else
                Console.WriteLine("BONUS -");

            Console.ReadKey();
        }
    }
}
