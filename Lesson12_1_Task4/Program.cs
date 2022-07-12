using System;

namespace Lesson12_1_Task4
{
    //Создать классы Point и Figure.
    //
    //Класс Point должен содержать два целочисленных поля и одно строковое поле.
    //Создать три свойства с одним методом доступа get.
    //Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
    //
    //Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
    //Создать два метода:
    //double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника;
    //void PerimeterCalculator(), который рассчитывает периметр многоугольника.
    //
    //Написать программу, которая выводит на экран название и периметр многоугольника.


    internal class Program
    {
        static double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        static void PerimeterCalculator(Figure figure)
        {
            double perimeter = 0;

            if (figure.Name == "triangle")
            {
                Console.WriteLine($"Figure is {figure.Name}");
                perimeter = (LengthSide(figure.Point1, figure.Point2) + LengthSide(figure.Point2, figure.Point3) + LengthSide(figure.Point3, figure.Point1));
                Console.Write($"Perimetr of {figure.Name} is: {perimeter}\n");
            }
            else if (figure.Name == "quadrangle")
                {
                    Console.WriteLine($"Figure is {figure.Name}");
                    perimeter = (LengthSide(figure.Point1, figure.Point2) + LengthSide(figure.Point2, figure.Point3) + LengthSide(figure.Point3, figure.Point4) + LengthSide(figure.Point4, figure.Point1));
                    Console.Write($"Perimetr of {figure.Name} is: {perimeter}\n");
                }
            else if (figure.Name == "pentagon")
            {
                Console.WriteLine($"Figure is {figure.Name}");
                perimeter = (LengthSide(figure.Point1, figure.Point2) + LengthSide(figure.Point2, figure.Point3) + LengthSide(figure.Point3, figure.Point4) + LengthSide(figure.Point4, figure.Point5) + LengthSide(figure.Point5, figure.Point1));
                Console.Write($"Perimetr of {figure.Name} is: {perimeter}\n");
            }
        }
        static void Main(string[] args)
        {
            Point point1 = new Point(0, 7, "A");        //triange   0, 2        //quadrangle    5, 3        //pentagon 0, 7
            Point point2 = new Point(6, 5, "B");       //triange   2, -2       //quadrangle    5, -3       //pentagon 6, 5 
            Point point3 = new Point(3, -4, "C");     //triange   -2, -2      //quadrangle    -5, -3       //pentagon 3, -4
            Point point4 = new Point(-4, -3, "D");                             //quadrangle    -5, 3        //pentagon -4, -3
            Point point5 = new Point(-6, -5, "E");                                                            //pentagon -6, -5


            Console.WriteLine($"{point1.Name}: {point1.X} , {point1.Y} ;");
            Console.WriteLine($"{point2.Name}: {point2.X} , {point2.Y} ;");
            Console.WriteLine($"{point3.Name}: {point3.X} , {point3.Y} ;");
            Console.WriteLine($"{point4.Name}: {point4.X} , {point4.Y} ;");
            Console.WriteLine($"{point5.Name}: {point5.X} , {point5.Y} ;");

            Console.WriteLine(new string('-', 100));
            Figure figure  = new Figure(point1, point2, point3);
            PerimeterCalculator(figure);
            
            Console.WriteLine(new string('-', 100));
            Figure figure2 = new Figure(point1, point2, point3, point4);
            PerimeterCalculator(figure2);

            Console.WriteLine(new string('-', 100));
            Figure figure3 = new Figure(point1, point2, point3, point4, point5);
            PerimeterCalculator(figure3);


            Console.ReadKey();

        }
    }
}
