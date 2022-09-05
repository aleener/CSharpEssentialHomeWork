using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_9_Task5
{
    // Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов.

    public delegate double Calc(int a, int b, int c);
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 5, z = 4;

            Calc noname = (a, b, c) => (double)(a + b + c) / 3;

            Console.WriteLine(noname(x,y,z));

            Console.ReadKey();

        }
    }
}
