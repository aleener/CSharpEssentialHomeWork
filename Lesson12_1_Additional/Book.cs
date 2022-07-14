using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_Additional
{
    internal class Book
    {
        private string title = null;
        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        public Book()
        {
           
        }
        public void Show()
        {
            Console.Write($" {title} ");
        }
    }
}
