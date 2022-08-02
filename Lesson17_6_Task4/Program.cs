using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_6_Task4
{
    //Требуется: создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию. 
    static class Extension
    {
        public static void Random(this int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 9);
            }
        }
        public static void Print(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        public static void Sort(this int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            array.Random();
            array.Print();
            array.Sort();
            array.Print();

            Console.ReadKey();
        }
    }
}
