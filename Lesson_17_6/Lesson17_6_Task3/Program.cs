using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_6_Task3
{
    //Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes, который позволит сохранять заметки читателя. 
    class Book
    {
        private static string note = "";
        public class Notes
        {
            public void NoteAdd(string value)
            { 
                note = value;
                Console.WriteLine(note);
            }
        }
        public void FindNext(string str)
        {
            Console.WriteLine("Find string : " + str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book.Notes instance = new Book.Notes();

            instance.NoteAdd("Add note");

            Console.ReadKey();
        }
    }
}
