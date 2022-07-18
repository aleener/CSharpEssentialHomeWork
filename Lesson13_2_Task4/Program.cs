using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_2_Task4
{
    internal class Program
    {
        //Создать класс Invoice.
        //В теле класса создать три поля int account, string customer, string provider,
        //которые должны быть проинициализированы один раз (при создании экземпляра данного класса)
        //без возможности их дальнейшего изменения.
        //В теле класса создать два закрытых поля string article, int quantity
        //Создать метод расчета стоимости заказа с НДС и без НДС.
        //Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Invoice order1 = new Invoice(1, "Ivanov Borys", "HARVEST");
            order1.Article = "TRAVELER";
            order1.Quantity = 2;
            order1.Price = 1975;
            order1.Show();

            Console.ReadKey();
        }
    }
}
