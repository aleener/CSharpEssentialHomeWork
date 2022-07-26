using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_4_Task2
{
    //Требуется: Создайте класс AbstractHandler.
    //В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
    //Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
    //Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа. 
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type format of document you want to work (XML,TXT,DOC).\nType EXIT to stop program.");
                string format = Console.ReadLine();
                format = format.ToLower();

                if (format == "xml")
                {
                    AbstractHandler XML = new XMLHandler();
                    Console.WriteLine(new String('-', 25));
                    XML.Open(); XML.Create(); XML.Change(); XML.Save();
                    Console.WriteLine(new String('-', 25));
                }
                else if (format == "txt")
                {
                    AbstractHandler TXT = new XMLHandler();
                    Console.WriteLine(new String('-', 25));
                    TXT.Open(); TXT.Create(); TXT.Change(); TXT.Save();
                    Console.WriteLine(new String('-', 25));
                }
                else if (format == "doc")
                {
                    AbstractHandler DOC = new DOCHandler();
                    Console.WriteLine(new String('-', 25));
                    DOC.Open(); DOC.Create(); DOC.Change(); DOC.Save();
                    Console.WriteLine(new String('-', 25));
                }
                else if (format == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(new String('-', 25));
                    Console.WriteLine("Enter correct format, please.\n");
                }
            }
        }
    }
}
