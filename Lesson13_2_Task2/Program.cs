using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_2_Task2
{
    internal class Program
    {
        //    Создать класс Converter.
        //    В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, 
        //    и инициализирует поля соответствующие курсу 3-х основных валют,
        //    по отношению к гривне – public Converter(double usd, double eur, double rub). 
        //    Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, 
        //    также программа должна производить конвертацию из указанных валют в гривну.
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            Console.OutputEncoding = Encoding.Unicode;

            double usd, eur, rub, value;

            usd = 29.25;
            eur = 29.28;
            rub = 0.49;

            Converter converter = new Converter(usd, eur, rub);

            do
            {
                Console.Write("Choose option:\n" +
                    "\n[1] HRN to USD | \u20B4 \u2192 \u0024" +
                    "\n[2] HRN to EUR | \u20B4 \u2192 \u20AC" +
                    "\n[3] HRN to RUB | \u20B4 \u2192 \u20BD" +
                    "\n[4] USD to HRN | \u0024 \u2192 \u20B4" +
                    "\n[5] EUR to HRN | \u20AC \u2192 \u20B4" +
                    "\n[6] RUB to HRN | \u20BD \u2192 \u20B4" +
                    "\n\nor press ESC to EXIT");
                
                input = Console.ReadKey();
                
                switch (input.Key)
                {
                    case (ConsoleKey.D1):
                        Console.Clear();
                        Console.Write("Enter sum of HRN (\u20B4): ");
                        value = double.Parse(Console.ReadLine());
                        Console.WriteLine($"[4] \u20B4 {value} = \u0024 {converter.HrnToUsd(value)} | exchange rate {usd}");
                        Console.Write("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case (ConsoleKey.D2):
                        Console.Clear();
                        Console.Write("Enter sum of HRN (\u20B4): ");
                        value = double.Parse(Console.ReadLine());
                        Console.WriteLine($"[4] \u20B4 {value} = \u20AC {converter.HrnToEur(value)} | exchange rate {eur}");
                        Console.Write("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case (ConsoleKey.D3):
                        Console.Clear();
                        Console.Write("Enter sum of HRN (\u0024): ");
                        value = double.Parse(Console.ReadLine());
                        Console.WriteLine($"[6] \u20B4 {value} = \u20BD {converter.HrnToRub(value)} | exchange rate {rub}");
                        Console.Write("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case (ConsoleKey.D4):
                        Console.Clear();
                        Console.Write("Enter sum of USD (\u0024): ");
                        value = double.Parse(Console.ReadLine());
                        Console.WriteLine($"[1] \u0024 {value} = \u20B4 {converter.UsdToHrn(value)} | exchange rate {usd}");
                        Console.Write("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case (ConsoleKey.D5):
                        Console.Clear();
                        Console.Write("Enter sum of EUR (\u20AC): ");
                        value = double.Parse(Console.ReadLine());
                        Console.WriteLine($"[2] \u20AC {value} = \u20B4 {converter.EurToHrn(value)} | exchange rate {eur}");
                        Console.Write("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case (ConsoleKey.D6):
                        Console.Clear();
                        Console.Write("Enter sum of RUB (\u20BD): ");
                        value = double.Parse(Console.ReadLine());
                        Console.WriteLine($"[3] \u20BD {value} = \u20B4 {converter.RubToHrn(value)} | exchange rate {rub}");
                        Console.Write("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong option!\n"+ new String('-',25)+"\n");
                        break;
                }
            } while (input.Key != ConsoleKey.Escape);

        }
    }
}
