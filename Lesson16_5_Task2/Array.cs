using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_5_Task2
{
    internal class Array
    {
        Random random = new Random();

        private int[] array;

        public Array(int value)
        {
            array = new int[value];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public void RandomFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 9);
            }
        }

        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public int MaxValue()
        {
            int max = default(int);

            max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            return max;
        }
        public int MinValue()
        {
            int min = default(int);

            min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min)
                {
                    continue;
                }
                else
                {
                    min = array[i];
                }
            }
            return min;
        }
        public int SumOfElements()
        {
            int sum = default(int);

            sum = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public double AverageOfElements()
        {
            double result = 0;
            for (int i = 0; i < array.Length; i++)
                result += array[i];

            return result / array.Length;
        }
        public void PrintOddValues()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] & 1) != 0)
                {
                    Console.Write($"{array[i]} ");
                }
                
            }
            Console.WriteLine();
        }
    }   
}
/* if (i < array.Length)
 {
     Console.Write(array[i]);
     Console.Write(",");
 }
 else
 {
     Console.Write(";");
 }
*/