using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_11_Task2
{
    #region
    //TODO: Создайте класс CarCollection.
    //TODO: 1. Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин.
    //TODO: 2. Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и года ее выпуска,
    //TODO: индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов.
    //TODO: 3. Создайте метод удаления всех машин автопарка. 
    #endregion

    public class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Car()
        {
            this.Name = default;
            this.Year = default;
        }
        public Car(string Name, int Year)
        {
            this.Name = Name;
            this.Year = Year;
        }
        public override string ToString()
        {
            return String.Format($"{this.Name}, {this.Year} ;");
        }
    }
    public class CarCollection<T> where T : Car
    {
        public T[] array;
        public int length { get; private set; }

        public CarCollection()
        {
            length = 0;
            array = new T[length];
        }
        
        public CarCollection(int length)
        {
            array = new T[length];
            this.length = length;
            for (int i = 0; i < length; i++)
                array[i] = (T)new Car();
        }
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public void AddCar(string name, int year)
        {
            length++;
            T[] copy = new T[length];
            for (int i = 0; i < length - 1; i++)
                copy[i] = array[i];
            copy[length - 1] = (T) new Car();
            copy[length - 1].Name = name;
            copy[length - 1].Year = year;
            array = copy;
        }
        public void Erase()
        {
            length = 0;
            T[] copy = new T[length];
            array = copy;
        }
        public void Print()
        {
            Console.WriteLine(new String('-', 20));
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i+1}. ");
                if (array[i] != null)
                    Console.WriteLine(array[i].ToString());
            }
            Console.WriteLine(new String('-', 20));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> Hangar = new CarCollection<Car>(1);
            
            Hangar.Print();

            
            Hangar.AddCar("Ford Falcon", 1972);
            Hangar.Print();


            Hangar.AddCar("Mitsubishi Pajero Sport III", 1996);
            Hangar.AddCar("Jaguar XE", 2014);
            Hangar.Print();

            Console.WriteLine($"Number of elements is: {Hangar.length}");
            Hangar.Erase();
            Hangar.Print();
            Console.WriteLine($"Number of elements is: {Hangar.length}");

            Console.ReadKey();
        }
    }
}
