using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_Task2
{
	//Создать класс с именем Address.
	//В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого поля, создать свойство с двумя методами доступа.
	//Создать экземпляр класса Address.
	//В поля экземпляра записать информацию о почтовом адресе.
	//Выведите на экран значения полей, описывающих адрес.
	class Address
	{
		public string index { get; set; }
		public string country { get; set; }
		public string city { get; set; }
		public string street { get; set; }
		public string house { get; set; }
		public string apartment { get; set; }
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Address addressMy = new Address()
			{
				index = "02068",
				country = "Ukraine",
				city = "Kyiv",
				street = "Oliinyka",
				house = "18",
				apartment = "253"
			};

			Console.WriteLine("My postal address is:\n{0}\n{1}, {2}\n{3} str, {4}/{5}", addressMy.index, addressMy.country, addressMy.city, addressMy.street, addressMy.house, addressMy.apartment);

			//Delay
			Console.ReadKey();
		}
	}
}
