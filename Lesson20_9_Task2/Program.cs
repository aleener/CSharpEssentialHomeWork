using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_9_Task2
{
    //Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление).
    //Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.
    //Лямбда оператор деления должен делать проверку деления на ноль.
    //Написать программу, которая будет выполнять арифметические действия, указанные пользователем. 
    public delegate double Calc(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc Add = (a, b) => a + b;
            Calc Sub = (a, b) => a - b;
            Calc Mul = (a, b) => a * b;
            Calc Div = (a, b) =>
            {
                if (b == 0) return double.PositiveInfinity;
                else return ((double)a / b);
            };

            while (true)
            {
            label:
                Console.Write("Enter A: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Choose math operation \'+\' \'-\' \'*\' or \'/\' : ");
                string option = Console.ReadLine();
                Console.Write("Enter B: ");
                int y = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case "+":
                        Console.WriteLine(Add(x, y));
                        break;
                    case "-":
                        Console.WriteLine(Sub(x, y));
                        break;
                    case "*":
                        Console.WriteLine(Mul(x, y));
                        break;
                    case "/":
                        Console.WriteLine(Div(x, y));
                        break;
                    default: goto label;
                }
            }
        }
    }
}
