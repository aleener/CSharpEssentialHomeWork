using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_6_Task6
{
    //Требуется: Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
    //Написать программу, которая выводит на экран основные арифметические операции.
    internal class Program
    {
        static void Main(string[] args)
        {
            int A,B;

            Console.Write("Enter number A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Enter number B: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine($"{A} + {B} = {Calculator.Add(A, B)}\n");
            Console.WriteLine($"{A} - {B} = {Calculator.Sub(A, B)}\n");
            Console.WriteLine($"{A} * {B} = {Calculator.Mul(A, B)}\n");
            Calculator.Div(A, B);

            Console.ReadKey();
        }
    }
}
