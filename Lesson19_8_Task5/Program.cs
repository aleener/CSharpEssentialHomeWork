using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_8_Task5
{
    //Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить количество дней до его следующего дня рождения.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year of birth: ");
            int Year = int.Parse(Console.ReadLine());
            Console.Write("Enter month of birth: ");
            int Month = int.Parse(Console.ReadLine());
            Console.Write("Enter day of birth: ");
            int Day = int.Parse(Console.ReadLine());


            DateTime birthDate = new DateTime(Year,Month,Day);

            //DateTime birthDate = new DateTime(1987, 12, 15);

            Console.WriteLine("Date of birth : {0:D}", birthDate);

            if (birthDate.Day == DateTime.Now.Day && birthDate.Month == DateTime.Now.Month)
            {
                Console.WriteLine("Happy Birthday!");
            }
            else if (birthDate.Month <= DateTime.Now.Month && birthDate.Day < DateTime.Now.Day)
            {
                DateTime nextBirthDay = new DateTime(DateTime.Now.AddYears(1).Year, birthDate.Month, birthDate.Day);
                Console.WriteLine("Date of next birthday : {0:D}", nextBirthDay);
                Console.WriteLine($"Days before next birthday: {(nextBirthDay - DateTime.Now).Days}");
            }
            else
            {
                DateTime nextBirthDay = new DateTime(DateTime.Now.Year, birthDate.Month, birthDate.Day);
                Console.WriteLine("Date of next birthday : {0:D}", nextBirthDay);
                Console.WriteLine($"Days before next birthday: {(nextBirthDay - DateTime.Now).Days}");
            }

            Console.ReadKey();

        }
    }
}
