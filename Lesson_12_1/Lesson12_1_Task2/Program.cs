using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_Task2
{
	//Требуется: 
	//Создать класс с именем Rectangle. В теле класса создать два поля, описывающие длины сторон double side1, side2. 
	//Создать пользовательский конструктор Rectangle(double side1, double side2),в теле которого поля side1 и side2 инициализируются значениями аргументов.
	//Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
	//Создать два свойства double Area и double Perimeter с одним методом доступа get.
	//Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.
	class Rectangle
	{
		private double side1, side2;

		public Rectangle() { }
		public Rectangle(double side1, double side2)
		{
			this.side1 = side1;
			this.side2 = side2;
		}
		static double AreaCalculator(double side1, double side2)
		{
			return side1 * side2;
		}
		static double PerimeterCalculator(double side1, double side2)
		{
			return (side1 + side2) * 2;
		}
		public double Area
		{
			get { return AreaCalculator(side1, side2); }
		}

		public double Perimetr
		{
			get { return PerimeterCalculator(side1,side2); }
		}

	}
	internal class Program
	{
		static void Main(string[] args)
		{
			double side1 = default, side2 = default;

			Console.Write("Eneter length of side1: ");
			side1 = double.Parse(Console.ReadLine());
			Console.Write("Eneter length of side2: ");
			side2 = double.Parse(Console.ReadLine());

			Rectangle rectangle	= new Rectangle(side1, side2);

			Console.WriteLine("Area of rectangle. side1 * side2 = {0}", rectangle.Area);
			Console.WriteLine("Perimetr of rectangle. (side1 + side2) * 2 = {0}", rectangle.Perimetr);

			//Delay
			Console.ReadKey();
		}
	}
}
