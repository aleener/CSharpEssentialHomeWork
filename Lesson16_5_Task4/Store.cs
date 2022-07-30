using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_5_Task4
{
    internal class Store
    {
        private Article[] array = new Article[5];

        public Article this[int index]
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

        public void Find(string value)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    if (array[i].Name == value)
                    {
                        Console.Write($"{i + 1}. ");
                        array[i].Print();
                        count++;
                        Console.WriteLine();
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"Store is haven't article with name \"{value}\"");
            }
            count = 0;
        }
        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                if (array[i] != null)
                {
                    array[i].Print();
                }
                Console.WriteLine();
            }
        }

    }
}
