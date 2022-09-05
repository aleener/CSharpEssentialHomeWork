using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_5_Task2
{
    //Требуется: Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
    //Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения. 
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());

            Array array = new Array(size);

            array.RandomFill();

            Console.Write("All values of {0} :\t\t", nameof(array));
            array.Print();
            Console.WriteLine("Max value of array is:\t\t{0}", array.MaxValue());
            Console.WriteLine("Min value of array is:\t\t{0}", array.MinValue());
            Console.WriteLine("Sum of all array values is:\t{0}", array.SumOfElements());
            Console.WriteLine("Arithmetic sum is:\t\t{0}", array.AverageOfElements());
            Console.Write("All array odd values:\t\t");
            array.PrintOddValues();

            Console.ReadKey();
        }
    }
}
