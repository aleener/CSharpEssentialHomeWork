using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_Task3
{
    internal class Book
    {
		Title title = null;
		Author author = null;
		Content content = null;


		void InitializeBook()
		{
			this.title = new Title();
			this.author = new Author();
			this.content = new Content();
		}
		public Book()
		{
			InitializeBook();
		}

		public string Title
		{
			set { this.title.text = value; }
		}
		public string Author
		{
			set { this.author.text = value; }
		}
		public string Content
		{
			set { this.content.text = value; }
		}

		public void Show()
		{
			this.title.Show();
			this.author.Show();
			this.content.Show();
		}
	}
}
