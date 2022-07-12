using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_Task4
{
    //Класс Point должен содержать два целочисленных поля и одно строковое поле.
    //Создать три свойства с одним методом доступа get.
    //Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
    internal class Point
    {
        private int x, y;
        private string name;

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name { get { return name; } }

        public Point() { }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
