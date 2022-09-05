using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_10_Task3
{
    //Реализуйте типизированный класс "Волшебный мешок".
    //Волшебство  заключается в том, что подарок сам появляется в мешке и зависит от того, кто пытается открыть мешок.
    //Причем подарок для одного существа может появиться только 1 раз в день.
    //Используйте ограничения типа - интерфейс со свойством, хранящим тип существа, которое пытается получить подарок из мешка.
    internal class Program
    {
        class MagicBag<T>
        {
            public T value;
            private bool option = false;
            private string type;

            public MagicBag(T value)
            {
                this.value = value;
                this.type = value.GetType().ToString();
            }
            public void GetPresent()
            {
                if (option == true)
                    Console.WriteLine("{0}, you have already received a gift", value.GetType());
                else if (type == "System.Int32" && option == false)
                {
                    Console.WriteLine("{0}, take your present", value.GetType());
                    option = true;
                }
                else if (type == "System.Double" && option == false)
                {
                    Console.WriteLine("{0}, take your present", value.GetType());
                    option = true;
                }
                else if (type == "System.String" && option == false)
                {
                    Console.WriteLine("{0}, take your present", value.GetType());
                    option = true;
                }

            }

        }
        static void Main(string[] args)
        {
            MagicBag<int> bag1 = new MagicBag<int>(1);
            bag1.GetPresent();
            bag1.GetPresent();

            MagicBag<double> bag2 = new MagicBag<double>(1.3);
            bag2.GetPresent();
            bag2.GetPresent();
            bag2.GetPresent();

            MagicBag<string> bag3 = new MagicBag<string>("bag");
            bag3.GetPresent();
            bag3.GetPresent();
            bag3.GetPresent();
            bag3.GetPresent();

            Console.ReadKey();

        }
    }
}
