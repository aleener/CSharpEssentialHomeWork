using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_2_Task3
{   
    //    Создать класс Employee.
    //    В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, 
    //    и инициализирует поля, соответствующие фамилии и имени сотрудника.
    //    Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
    //    Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор.
    internal class Employee
    {
        string firstName;
        string lastName;
        string function;
        int yearsOfWork;
        DateTime recruited;

        public string FirstName
        { 
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public string Function
        { 
            set { function = value; }
            get { return function; }
        }
        public int YearsOfWork
        {
            set { yearsOfWork = value; }
            get { return yearsOfWork; }
        }
        public DateTime Recruited
        {
            set { recruited = value; }
            get { return recruited; }
        }
        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void Show()
        {
            Console.WriteLine($"First name:\t{this.FirstName}\n" +
                  $"Last name:\t{this.LastName}\n" +
                  $"Function:\t{this.Function}\n" +
                 // $"Recruited:\t{this.Recruited.ToShortDateString()}\n" +
                 // $"Years of work:\t{this.YearsOfWork}\n" +
                  $"{new string('-',30)}");
        }
        public void Salary()
        {
            //sum for 1 person - 10000
            double sum = 10000;
            //specialist's coefficient  - 1
            double specC = 1.5;
            //chief's coefficient       - 2.5
            double chiefC = 2.5;
            // year coefficient "<5"    - 0.8
            double yC1 = 0.8;
            // year coefficient ">=5<10 - 1
            double yC2 = 1;
            // year coefficient ">10"   - 1.2
            double yC3 = 1.2;
            //tax                       - 21,5%
            double tax = 0.215;

            if (this.yearsOfWork < 5)
            {
                if (this.function == "Specialist")
                {
                    Console.WriteLine($"Salary:\t{sum * specC * yC1} \u20B4"); 
                    Console.WriteLine($"Tax:\t{(sum * specC * yC1)*tax} \u20B4");
                }
                else
                {
                    Console.WriteLine($"Salary:\t{sum * chiefC * yC1} \u20B4");
                    Console.WriteLine($"Tax:\t{(sum * chiefC * yC1) * tax} \u20B4");
                }
            }
            else if (this.yearsOfWork >= 5 && yearsOfWork < 10)
            {
                if (this.function == "Specialist")
                {
                    Console.WriteLine($"Salary:\t{sum * specC * yC2} \u20B4");
                    Console.WriteLine($"Tax:\t{(sum * specC * yC2) * tax} \u20B4");
                }
                else
                {
                    Console.WriteLine($"Salary:\t{sum * chiefC * yC2} \u20B4");
                    Console.WriteLine($"Tax:\t{(sum * chiefC * yC2) * tax} \u20B4");
                }
            }
            else
            {
                if (this.function == "Specialist")
                {
                    Console.WriteLine($"Salary:\t{sum * specC * yC3} \u20B4");
                    Console.WriteLine($"Tax:\t{(sum * specC * yC3) * tax} \u20B4");
                }
                else
                {
                    Console.WriteLine($"Salary:\t{sum * chiefC * yC3} \u20B4");
                    Console.WriteLine($"Tax:\t{(sum * chiefC * yC3) * tax} \u20B4");
                }
            }
        }


    }
}
