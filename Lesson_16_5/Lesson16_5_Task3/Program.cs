using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_5_Task3
{
    //Требуется: Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера с возможностью изменения числа строк и столбцов.
    //Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков. 
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(3, 6);

            Console.WriteLine(matrix.GetHashCode());
            matrix.RandomFill();
            matrix.Print();
            Console.WriteLine(new String('-',35));

            Console.WriteLine(matrix.GetHashCode());
            matrix.ChangeSize(5,5);
            matrix.RandomFill();
            matrix.Print();
            Console.WriteLine(new String('-', 35));

            Console.WriteLine(matrix.GetHashCode());
            matrix.ChangeSize(4, 2);
            matrix.RandomFill();
            matrix.Print();
            Console.WriteLine(new String('-', 35));

            Console.WriteLine(matrix.GetHashCode());
            matrix.ChangeSize(0, -1);
            matrix.RandomFill();
            matrix.Print();
            Console.WriteLine(new String('-', 35));

            Console.ReadKey();
        }
    }
}
