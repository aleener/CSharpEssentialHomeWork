using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task4
{
    //Требуется cоздать класс DocumentWorker. В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
    //В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт", "Редактирование документа в версии О", "Сохранение документа в версии О".

    //Создайте производный класс ProDocumentWorker.
    //Переопределите соответствующие методы, при переопределении методов выводите следующие строки: "Документ отредактирован", "Документ сохранен в старом формате, сохранение в других форматах есть в версии Эксперт".

    //Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
    //Переопределите подходящий способ.При вызове данного метода необходимо выводить на экран документ сохраненный в новом формате.

    //В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
    //Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса),
    //если пользователь ввел номера ключа доступа pro и exp, то должен создать экземпляр соответствующей версии класса, приведенный к базовому - DocumentWorker.
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker doc1;
            string key;

            while (true)
            {
                Console.Write("Enter a key: ");
                key = Console.ReadLine();

                if (key == "pro")
                {
                    doc1 = new ProDocumentWorker();
                }
                else if (key == "exp")
                {
                    doc1 = new ExpertDocumentWorker();
                }
                else
                    doc1 = new DocumentWorker();

                Console.WriteLine($"\ndoc1 Id: {doc1.GetHashCode()}");
                
                doc1.OpenDocument();
                doc1.EditDocument();
                doc1.SaveDocument();

                Console.WriteLine(new String('-',25));
            } 
        }
    }
}
