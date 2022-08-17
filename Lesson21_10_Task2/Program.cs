using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_10_Task2
{
    //Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его 
    //экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс 
    //взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для 
    //получения значения элемента по указанному индексу и свойство только для чтения для получения 
    //общего количества элементов. 

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
                    Console.WriteLine("null");
                else
                    Console.WriteLine(this.array[i]);
            }
            Console.WriteLine(new string('-', 25));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int?> myList = new MyList<int?>(2);

            myList.Print();
            myList.Add(42);
            myList.Print();
            myList.Add('s');
            myList.Print();
            myList.Add(90210);
            myList.Print();
            myList.Add();
            myList.Print();
            Console.WriteLine(myList[2]);
            Console.ReadKey();
        }
    }
}