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
	internal class Program
	{
		static void Main(string[] args)
		{
			Book book = new Book();
			book.Title = "C# the Complete Reference";
			book.Content = "C# allows developers to construct services and applications for the Web with a single, logical tool.";
			book.Author = "Herbert Schildt";

			book.Show();
			/*
            Console.WriteLine(new string('-',100));

			Book book2 = new Book();
			book2.Title = "C# the Complete Reference";
			book2.Content = "C# allows developers to construct services and applications for the Web with a single, logical tool.";
			book2.Author = "Herbert Schildt";

			book2.Show();*/

			// Delay.
			Console.ReadKey();	
		}
	}
}
