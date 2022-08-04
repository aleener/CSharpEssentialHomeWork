using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_7_Task3
{
    //Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
    //В классе Program создайте два метода:
    //static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass значение «изменено».
    //static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct значение «изменено».
    //Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры структуры и класса.
    //Измените, значения полей экземпляров на «не изменено», а затем вызовите методы ClassTaker и StruktTaker.
    //Выведите на экран значения полей экземпляров.
    //Проанализируйте полученные результаты. 
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }
    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            
            myClass.change = "Changed";
            Console.WriteLine($"ClassTaker method myClass.change\t{myClass.change} {myClass.change.GetHashCode()}");
        }
        static void StruktTaker(MyStruct myStruct)
        {

            myStruct.change = "Changed";
            Console.WriteLine($"StruktTaker method myStruct.change\t{myStruct.change} {myStruct.change.GetHashCode()}");
        } 
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "Not changed";
            myStruct.change = "Not changed";

            Console.WriteLine($"myClass.change\t{myClass.change} {myClass.change.GetHashCode()}");
            Console.WriteLine($"myStruct.change\t{myStruct.change} {myStruct.change.GetHashCode()}");
            Console.WriteLine(new String('-', 50));

            ClassTaker(myClass);
            StruktTaker(myStruct);
            Console.WriteLine(new String('-', 20));

            Console.WriteLine($"myClass.change\t{myClass.change} {myClass.change.GetHashCode()}");
            Console.WriteLine($"myStruct.change\t{myStruct.change} {myStruct.change.GetHashCode()}");
            Console.WriteLine(new String('-', 20));

            myStruct.change = "Changed";
            Console.WriteLine($"myStruct.change\t{myStruct.change} {myStruct.change.GetHashCode()}");
            Console.WriteLine(new String('-', 20));

            Console.ReadKey();

            //При передаче структуры в качестве параметра в метод создаётся отдельная копия объекта, которая после копирования живёт «своей жизнью» (классы – создаётся ссылка на тот же класс(т.н.instance)).
            //Поэтому, при выполнении метода static void StruktTaker(MyStruct myStruct) значение поля меняется и мы его не возвращаем, но вот в основном теле программы поле остается прежним.

        }
    }
}
