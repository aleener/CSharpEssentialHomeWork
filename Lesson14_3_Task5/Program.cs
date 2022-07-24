using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task5
{
    //Требуется: Создайте класс Printer.
    //В теле класса создайте метод void Print(string value),который выводит на экран значение аргумента.
    //Реализуйте возможность того, чтобы в случае наследования от данного класса других классов,и вызове соответствующего метода их экземпляра,
    //строки, переданные в качестве аргументов методов, выводились разными цветами.
    //Обязательно используйте приведение типов.
    internal class Program
    {
        static void Main(string[] args)
        {
            string @string = "Hello world";

            Printer printer = new Printer();

            Console.WriteLine($"{new string('-', 25)}\n{printer.GetHashCode()}");
            printer.Print(@string);
            
            printer = new BluePrint();
            Console.WriteLine($"{new string('-', 25)}\n{printer.GetHashCode()}");
            printer.Print(@string);
            
            printer = new YellowPrint();
            Console.WriteLine($"{new string('-', 25)}\n{printer.GetHashCode()}");
            printer.Print(@string);
            
            printer = new Printer();
            Console.WriteLine($"{new string('-', 25)}\n{printer.GetHashCode()}");
            printer.Print(@string); 

            Console.ReadKey();
        }
    }
}
