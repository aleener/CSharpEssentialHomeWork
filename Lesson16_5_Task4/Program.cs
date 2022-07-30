using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_5_Task4
{
    //Создать класс Article, содержащий следующие закрытые поля:
    //• название товара;
    //• название магазина, в котором продается товар;
    //• стоимость товара в гривнах.
    //Создать класс Store, содержащий закрытый массив элементов типа Article. Обеспечить следующие возможности:
    //• вывод информации о товаре по номеру с помощью индекса;
    //• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение;
    //Написать программу, вывода на экран информацию о товаре.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Store store = new Store();

            store[0] = new Article("Traveler", "HARVEST", 1975);
            store[1] = new Article("Chrome", "HARVEST", 1865);
            store[2] = new Article("Aviapack", "HARVEST", 1645);
            store[3] = new Article("Control", "HARVEST", 1620);
            store[4] = new Article("Chrome", "HARVEST", 1895);

            store.Print();
            Console.WriteLine(new String('-', 35));
            Console.Write("Type number of article you\'re want to print: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write($"{number}. ");
            store[number-1].Print();
            Console.WriteLine();
            Console.WriteLine(new String('-', 35));

            Console.Write("Type name of article you\'re want to print: ");
            string find = Console.ReadLine();
            store.Find(find);


            Console.ReadKey();
        }
    }
}
