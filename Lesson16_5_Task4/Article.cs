using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_5_Task4
{
    internal class Article
    {
        private string name;
        private string provider;
        private double price;

        public string Name
        { 
            get { return name; }
            set { name = value; }
        }
        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }
        public double Price
        { 
            get { return price; }
            set { price = value; }
        }
        public Article()
        { }

        public Article(string name, string provider, double price)
        { 
            this.name = name;
            this.provider = provider;
            this.price = price;
        }

        public void Print()
        {
                Console.Write($"{this.name}\t({this.provider})\t\u20B4{this.price}");
        }
    }
}
