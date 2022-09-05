using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_2_Task4
{
    //Создать класс Invoice.
    //В теле класса создать три поля int account, string customer, string provider,
    //которые должны быть проинициализированы один раз (при создании экземпляра данного класса)
    //без возможности их дальнейшего изменения.
    //В теле класса создать два закрытых поля string article, int quantity
    //Создать метод расчета стоимости заказа с НДС и без НДС.
    internal class Invoice
    {
        int account { get; } //рахунок
        string customer { get; } //клієнт
        string provider { get; } //постачальник
        string article; //товар
        int quantity; //кількість
        double price; //ціна

        public string Article
        { 
            get { return article; }
            set { article = value; }
        }
        
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Price
        {
            set { price = value; }
        }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        private double totalPrice()
        { 
            return (double)price * Quantity;
        }
        private double totalPriceVATfree()
        {
            return (double)price * Quantity * 0.8;
        }
        public void Show()
        {
            Console.WriteLine(  $"Account:\t{this.account}\n" +
                                $"Customer:\t{this.customer}\n" +
                                $"Provider:\t{this.provider}\n" +
                                $"Article:\t{this.article}\n" +
                                $"Quantity:\t{this.quantity}\n" +
                                $"{new string('-', 30)}\n" +
                                $"Price VAT free:\t{totalPriceVATfree()} \u20B4\n" +
                                $"Total price:\t{totalPrice()} \u20B4\n");
        }
    }
}
