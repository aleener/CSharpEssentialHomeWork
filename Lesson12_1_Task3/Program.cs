using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_Task3
{
	//Создать класс Book.
	//Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().
	//Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
	//Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
	class Book
	{
		public Title title = null;
		public Author author = null;
		public Content content = null;
		void InitializeBook()
		{
			this.title = new Title();
			this.author = new Author();
			this.content = new Content();
		}
		public string Title
		{
			set { this.title.title = value; }
		}
		public string Author
		{
			set { this.author.author = value; }
		}
		public string Content
		{ 
			set { this.content.content = value; }
		}

		public void Show()
		{
			this.title.Show();
			this.author.Show();
			this.content.Show();
		}
	}
	class Title
	{
		public string title;
		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(title);
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
	class Author
	{
		public string author;
		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(author);
			Console.ForegroundColor = ConsoleColor.Gray;
		}

	}
	class Content
	{
		public string content;

		public string text
		{
			set
			{
				text = value;
			}
		}
		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(text);
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Book book = new Book();
			book.Title = "C# the Complete Reference";
			book.Content = "C# allows developers to construct services and applications for the Web with a single, logical tool. Eager market-developers and programmers using C, C++, Visual Basic, and Java require information about C#. Microsoft considers C# to be as a critical piece of its .NET platform. This book features coverage of the C# language.";
			book.Author = "Herbert Schildt";

			book.Show();

			// Delay.
			Console.ReadKey();
		}
	}
}
