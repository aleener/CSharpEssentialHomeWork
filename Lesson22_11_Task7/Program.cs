using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_11_Task7
{
    #region Task
    // TODO: Создайте обобщенный класс MyClass, содержащий статический фабричный метод – T FacrotyMethod(),
    // TODO: который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т).
    // TODO: Каким должен быть тип, подставляемый под T?
    #endregion
    public class Task7<T>
    {
       public static Task7<T> FacrotyMethod()
        { 
            return new Task7<T>();
        }
    }
    public class Task6
    {
        public int field { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance1 = Task7<int>.FacrotyMethod();
            var instance2 = Task7<string>.FacrotyMethod();
            var instance3 = Task7<Task6>.FacrotyMethod();


            Console.WriteLine(instance1);
            Console.WriteLine(instance2);
            Console.WriteLine(instance3);


            Console.ReadKey();
        }
    }
}
