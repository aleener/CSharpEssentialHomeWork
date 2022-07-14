using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_Additional
{
    internal class BookShop
    {
        private Book book;
        private Author author;

        public BookShop()
        {
            this.book = new Book();
            this.author = new Author();
        }
        public string Book
        {
            set { this.book.Title = value; }
            get { return this.book.Title; }   
        }
        public string Author
        {
            set { this.author.Name = value; }
            get { return this.author.Name; }
        }
        public void Show()
        {
            this.book.Show();
            this.author.Show();
        }
    }
}
