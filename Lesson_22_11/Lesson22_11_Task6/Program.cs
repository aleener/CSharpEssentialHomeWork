using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_11_Task6
{
    //В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, переберите данную коллекцию с помощью, цикла for. С какой проблемой вы столкнулись?


    //Проблем не возникло, так как ArraList работает с полем типа object и при работе с данными происходит процедура box’инга unbox’инга, что может сказать на производительсти при работе с большим обьемом данных.
    public class Task6
    {
        public int field { get; set; }   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList instance = new ArrayList();
            Task6 instance1 = new Task6();
            instance1.field = 4;

            instance.Add(1);
            instance.Add((object)2);
            instance.Add(3.ToString());
            instance.Add(instance1.field);

            for (int i = 0; i < instance.Count; i++)
            {
                Console.WriteLine($"{instance[i]}, {instance[i].GetType()}");
            }

            Console.ReadKey();
        }
    }
}
