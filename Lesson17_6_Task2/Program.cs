﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_6_Task2
{
    //Требуется: Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге из примера урока 005_Delegation.
    //При вызове этого метода, производится последовательный поиск строки в книге. 

    static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Book book = new Book();
            book.FindNext(str);
        }
    }
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Find string : " + str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            FindAndReplaceManager.FindNext("from static");

            Console.ReadKey();
        }
    }
}
