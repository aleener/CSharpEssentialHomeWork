using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_2_Task6
{
    //Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты).
    //Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании экземпляра данного класса) без возможности его дальнейшего изменения.
    //Реализуйте вывод на экран информации о пользователе.
    internal class User
    {
        string login;
        string firstName;
        string lastName;
        DateTime createDate = DateTime.Now;

        public User() { }
        public User(string login, string firstName, string lastName)
        {
            this.login = LoginNotNull(login);
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //перевірка запису значення до поля Login, не Null і не пробіли
        private string LoginNotNull(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Login must not be blank");
            return value;
        }

        public void show()
        {
            Console.WriteLine($"Login:\t\t{this.login}\n" +
                    $"First name:\t{this.firstName}\n" +
                    $"Last name:\t{this.lastName}\n" +
                    $"Create date:\t{this.createDate}\n");
        }
    }
}
