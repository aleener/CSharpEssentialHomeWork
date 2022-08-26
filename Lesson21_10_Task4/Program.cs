using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_10_Task4
{
    #region
    //TODO: 1. Создайте расширяющий метод: public static T[] GetArray(this MyList list)
    //TODO: 2. Примените расширяющий метод к экземпляру типа MyList, разработанному в домашнем задании 2 для данного урока.
    //TODO: 3. Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). 
    #endregion
    public static class MyListExt
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list.array;
        }
    }
    public class MyList<T>
    {
        public T[] array;
        public int length { get; private set; }

        public MyList()
        {
            array = new T[0];
            length = 0;
        }
        public MyList(int length)
        {
            array = new T[length];
            this.length = length;
        }
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public void Add()
        {
            length++;
            T[] copy = new T[length];
            for (int i = 0; i < length - 1; i++)
                copy[i] = array[i];
            array = copy;
        }
        public void Add(T item)
        {
            length++;
            T[] copy = new T[length];
            for (int i = 0; i < length - 1; i++)
                copy[i] = array[i];
            copy[length - 1] = item;
            array = copy;
        }
        public void Print()
        {
            Console.WriteLine("Size: {0}", length);
            for (int i = 0; i < length; i++)
            {
                if (this.array[i] == null)
                    Console.WriteLine($"{i + 1}. null");
                else
                    Console.WriteLine($"{i + 1}. {this.array[i]}");
            }
            Console.WriteLine(new string('-', 25));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int?> myList = new MyList<int?>(2);

            myList.Add(42);
            myList.Add('s');
            myList.Add(90210);
            myList.Add();
            myList.Print();

            var array = myList.GetArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {array[i]}");
            }
            Console.ReadKey();
        }
    }
}
