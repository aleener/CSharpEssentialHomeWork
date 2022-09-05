using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_11_Task3
{
    #region
    //TODO:Используя Visual Studio, создайте проект по шаблону Console Application.
    //TODO: 1. Создайте класс Dictionary.
    //TODO: Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен System.Collections.Generic.
    //TODO: Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать
    //TODO: 1.1 метод добавления пар элементов,
    //TODO: 1.2 индексатор для получения значения элемента по указанному индексу и
    //TODO: 1.3 свойство только для чтения для получения общего количества пар элементов.
    #endregion

    public class Dictionary<TKey, TValue>
    {
        public int size { get; private set; }

        private TKey[] key;
        private TValue[] value;

        public TValue this[TKey key]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < this.key.Length; i++)
                {
                    if (key.Equals(this.key[i]))
                    {
                        index = i;
                        return this.value[index];
                    }
                }
                return default(TValue);
            }
        }
        public void Add(TKey key, TValue value)
        {
            if (this.key == null || !this.key.Contains(key))

            {
                size++;
                Array.Resize(ref this.key, size);
                this.key[size - 1] = key;
                Array.Resize(ref this.value, size);
                this.value[size - 1] = value;
            }
        }
        public void Print()
        {
            for (int i = 0; i < size; i++)
            {

                if (key[i] != null || value[i] != null)
                    Console.WriteLine($"| {this.key[i]}\t| {this.value[i]}");
            }
            Console.WriteLine(new string('-', 20));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Shop = new Dictionary<int, string>();

            Shop.Print();
            Shop.Add(1, "First");
            Shop.Add(1, "First");
            Shop.Add(1, "First");
            Shop.Add(1, "First");
            Shop.Print();
            Shop.Add(42, "Second");
            Shop.Add(999, "third");
            Shop.Print();

            Console.WriteLine(Shop[1]);
            Console.WriteLine(Shop[999]);
            Console.WriteLine(Shop[42]);
            Console.WriteLine(Shop[4]);
            Console.WriteLine(Shop[30]);
            Console.WriteLine(Shop[1]);

            Console.WriteLine($"Size of dictionary: {Shop.size}");

            Console.ReadKey();

        }
    }
}
