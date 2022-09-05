using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_7_Task5
{
    //Создайте структуру с именем - Notebook. Поля структуры: модель, производитель, цена.
    //В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран.
    struct Notebook
    {
        string model;
        string provider;
        double price;

        public Notebook(string model, string provider, double price)
        { 
            this.model = model;
            this.provider = provider;
            this.price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Model: {this.model}\nProvider: {this.provider}\nPrice: {this.price}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("Preadator", "ASUS", 35450);

            notebook1.Print();

            Console.ReadKey();
        }
    }
}
