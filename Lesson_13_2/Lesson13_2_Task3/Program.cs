using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_2_Task3
{
    internal class Program
    {
        //    Создать класс Employee.
        //    В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, 
        //    и инициализирует поля, соответствующие фамилии и имени сотрудника.
        //    Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
        //    Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор.
        private static int GetYearsOfWork(DateTime d1, DateTime d2)
        {
            var r = d2.Year - d1.Year;
            return d1.AddYears(r) <= d2 ? r : r - 1;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Employee person1 = new Employee("Borys", "Ivanov");
            person1.Function = "Chief"; //Chief Specialist
            person1.Recruited = new DateTime(2018, 04, 03);
            person1.YearsOfWork = GetYearsOfWork(person1.Recruited, DateTime.Now);

            person1.Show();
            person1.Salary();

            Console.ReadKey();
        }
    }
}
