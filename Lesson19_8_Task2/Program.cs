using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_8_Task2
{
    //Создайте статический класс с методом void Print (string stroka, int color),
    //который выводит на экран строку заданным цветом.
    //Используя перечисление, создайте набор цветов, доступных пользователю.
    //Ввод строки и выбор цвета предоставьте пользователю. 
    enum Colors
    {
        Red = 1,
        White = 2,
        Yellow = 3,
        Green = 4,
        Blue = 5,
        Cyan = 6,
        Magneta = 7
    }
    static class Color
    {
        public static void Print(string stroka, int color)
        {
            Colors take = (Colors)color;

            switch (take)
            {
                case Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(stroka);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Colors.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(stroka);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(stroka);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(stroka);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Colors.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(stroka);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Colors.Magneta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(stroka);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                    default:
                    Console.WriteLine("!!!You choosed wrong color!!!");
                    break;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter string value: ");
                string @string = Console.ReadLine();
                Console.Write("Choose color (from 1 to 7): ");
                int color = int.Parse(Console.ReadLine());
                Color.Print(@string, color);
                Console.WriteLine(new string ('-',15));
            }
        }
    }
}
