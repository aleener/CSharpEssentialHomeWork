using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_7_Task2
{
    //Требуется: Описать структуру с именем Train, содержащую следующие поля:
    //название пункта назначения,номер поезда,время отправления.
    //Написать программу, выполняющую следующие действия:
    //ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов);
    //вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет, вывести соответствующее сообщение). 
    static class Extension
    {
        public static void Print(this Train[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {array[i].departureTime}\n   {array[i].number}\n   {array[i].destination}");
            }
            Console.WriteLine();
        }
        public static void Print(this Train[] array, int i)
        {
                Console.WriteLine($"{i + 1}. {array[i].departureTime}\n   {array[i].number}\n   {array[i].destination}");
        }
        public static void Sort(this Train[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].number > array[j].number)
                    {
                        temp = array[i].number;
                        array[i].number = array[j].number;
                        array[j].number = temp;
                    }
                }
            }
        }
        public static void Fill(this Train[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Train();
            }

            array[0].destination = "Kyiv";
            array[0].number = 42;
            array[0].departureTime = new TimeSpan(1, 44, 0);

            array[1].destination = "Lviv";
            array[1].number = 24;
            array[1].departureTime = new TimeSpan(15, 42, 0);

            array[2].destination = "Dnepr";
            array[2].number = 6;
            array[2].departureTime = new TimeSpan(12, 24, 0);

            array[3].destination = "Kharkiv";
            array[3].number = 143;
            array[3].departureTime = new TimeSpan(2, 36, 0);

            array[4].destination = "Kherson";
            array[4].number = 19;
            array[4].departureTime = new TimeSpan(11, 15, 0);

            array[5].destination = "Donetsk";
            array[5].number = 33;
            array[5].departureTime = new TimeSpan(15, 53, 0);

            array[6].destination = "Lygansk";
            array[6].number = 9;
            array[6].departureTime = new TimeSpan(3, 19, 0);

            array[7].destination = "Poltava";
            array[7].number = 42;
            array[7].departureTime = new TimeSpan(13, 18, 0);
        }
    }
    public struct Train
    {
        public string destination { get; set; }
        public int number { get; set; }
        public TimeSpan departureTime { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Train[] array = new Train[8];

            //array.Fill();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Fill {i + 1} element of array");
                Console.Write("Destination: ");
                array[i].destination = Console.ReadLine();
                Console.Write($"Number of train: ");
                array[i].number = int.Parse(Console.ReadLine());
                Console.Write($"Departure time (format HH:mm): ");
                array[i].departureTime = TimeSpan.Parse(Console.ReadLine());
                Console.Clear();
            }

            array.Print();
            array.Sort();
            array.Print();

            Console.Write("Enter number of train for search: ");
            int value = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].number == value)
                {
                    array.Print(i);
                    count++;
                }     
            }
            if (count == 0)
            {
                Console.WriteLine($"No such train (Number: {value}) in array");
            }


            Console.ReadKey();
        }
    }
}
