using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_Additional
{
    //Нужно написать консольное приложение, которое позволит:
    //1. Добавлять новые книги в магазин
    //2. Удалять книги(по названию, по имени автора)
    //3. Поиск книг по названию
    //4. Посмотреть все добавленніе книги

    //Для этого нужно создать три класса Book(книга), Author(автор), BookShop(магазин книг). Вся основная логика будет в Program.cs.

    internal class Program
    {
        //1. Добавлять новые книги в магазин
        static void AddBook(ref BookShop[] store, int position, string title, string author)
        {
            position = position - 1;
            store[position].Author = author;
            store[position].Book = title;
        }
        //2. Удалять книги(по названию, по имени автора)
        static void DelBookOnTitle(ref BookShop[] store,string title)
        {
            for (int i = 0; i < store.Length; i++)
            {
                if (store[i].Book == title)
                {
                    store[i].Author = null;
                    store[i].Book = null;
                }
            }
        }
        static void DelBookOnAuthor(ref BookShop[] store, string title)
        {
            for (int i = 0; i < store.Length; i++)
            {
                if (store[i].Author == title)
                {
                    store[i].Author = null;
                    store[i].Book = null;
                }
            }
        }
        //3. Поиск книг по названию
        static void FindBook(BookShop[] store, string title)
        {
            for (int i = 0; i < store.Length; i++)
            {
                if (store[i].Book == title)
                {
                    Console.Write($"{i + 1}. ");
                    store[i].Show();
                    Console.WriteLine();
                }
            }
        }
        //4. Посмотреть все добавленніе книги
        static void ShowStore(BookShop[] store)
        {
            Console.WriteLine("BookShop books:");
            for (int i = 0; i < store.Length; i++)
            {
                Console.Write($"{i+1}. ");
                store[i].Show();
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            BookShop[] store = new BookShop[10];
            for (int i = 0; i < store.Length; i++)
            {
                store[i] = new BookShop();
            }
            Console.WriteLine("Created BookShop");
            Console.WriteLine(new string('-',50));
            ShowStore(store);
            Console.ReadKey();
            Console.Clear();

            AddBook(ref store, 1, "C#", "Skeet");
            AddBook(ref store, 3, "C++", "Lippman");
            AddBook(ref store, 5, "C", "Albahari");
            AddBook(ref store, 8, "C#", "Lippman");
            AddBook(ref store, 10, "C++", "Richter");
            Console.WriteLine("View all added books");
            Console.WriteLine(new string('-', 50));
            ShowStore(store);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("View all found books C#");
            Console.WriteLine(new string('-', 50));
            FindBook(store,"C#");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("View all added books");
            Console.WriteLine(new string('-', 50));
            ShowStore(store);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("View books after DelBookOnTitle C");
            Console.WriteLine(new string('-', 50));
            DelBookOnTitle(ref store,"C");
            ShowStore(store);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("View books after DelBookOnAuthor Lippman");
            Console.WriteLine(new string('-', 50));
            DelBookOnAuthor(ref store,"Lippman");
            ShowStore(store);
            Console.ReadKey();
            Console.Clear();




        }
    }
}
