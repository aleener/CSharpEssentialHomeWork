using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task3
{
    // Требуется: Создать класс Vehicle.
    // В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
    // Создайте 3 производных класса Plane, Саг и Ship.
    // Для класса Plane должна быть определена высота и количество пассажиров.
    // Для класса Ship — количество пассажиров и порт приписки.
    // Написать программу, которая выводит на экран информацию о каждом средстве передвижения. 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Car vehicle1 = new Car(53.42, 42.35, 62000, 120, 2001);
            Plane vehicle2 = new Plane(23.50,32.27,35000000,780,1987,3220,96);
            Ship vehicle3 = new Ship(38.43, 45.76, 420340500, 820, 2014, "Odessa", 420000);

            Console.WriteLine($"\t\t{nameof(vehicle1)}\n{new string('-',40)}");
            vehicle1.Print();
            Console.WriteLine($"\t\t{nameof(vehicle2)}\n{new string('-', 40)}");
            vehicle2.Print();
            Console.WriteLine($"\t\t{nameof(vehicle3)}\n{new string('-', 40)}");
            vehicle3.Print();


            Console.ReadKey();

        }
    }
}
