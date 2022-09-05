using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_9_Task3
{
    //Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве.
    //Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int. 

    public delegate int number();
    public delegate double mass(number[] x);
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            number nmbr = delegate () {
                int r = random.Next(1, 100);
                Console.WriteLine(r);
                return r; 
            };
            
            mass nmbrs = delegate (number[] x)
            {
                int sum = 0;
                for (int i = 0; i < x.Length; i++)
                { 
                    sum = sum + x[i]();
                }
                return (double)sum/x.Length;
            };
           
            Console.WriteLine(nmbrs(new number[5] {nmbr, nmbr, nmbr, nmbr, nmbr}));

            Console.ReadKey();
        }
    }
}
