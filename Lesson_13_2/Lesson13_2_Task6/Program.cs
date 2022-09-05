using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_2_Task6
{
    internal class Program
    {
        //Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты).
        //Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании экземпляра данного класса) без возможности его дальнейшего изменения.
        //Реализуйте вывод на экран информации о пользователе.
        static void Main(string[] args)
        {
            User user1 = new User();
            User user2 = new User("Br1tv@","Borys","Ivanov");
            
            user1.show();
            Console.WriteLine(new String ('-',30));
            user2.show();
            Console.WriteLine(new String('-', 30));
            Console.ReadKey();
        }
    }
}
