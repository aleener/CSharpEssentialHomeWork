using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_11_Task4
{
    //Создайте класс ArrayList.
    //Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections. 
    internal static class EmptyArray<T>
    {
        public static readonly T[] Value;
        static EmptyArray()
        {
            EmptyArray<T>.Value = new T[0];
        }

    }
    public class ArrayList
    {
        private object[] array;
        public int size { get; private set; }
        private static readonly object[] emptyArray = EmptyArray<object>.Value;

        public ArrayList()
        {
            this.array = emptyArray;
        }

        public ArrayList(int length)
        {
            if (length == 0)
            {
                array = emptyArray;
            }
            else 
            {
                array = new object[length];
                size = length;
            }
        }
        public object this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public void Add(object value)
        {
            size++;
            object[] copy = new object[size];
            for (int i = 0; i < size - 1; i++)
                copy[i] = array[i];
            copy[size - 1] = value;
            array = copy;
        }
        public void Print()
        {
            Console.WriteLine($"Size: {array.Length}");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(new String('-', 10));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList aList = new ArrayList();

            aList.Print();
            aList.Add(1);
            aList.Add((object)2);   
            aList.Print();

            Console.ReadKey();
        }
    }
}
