using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.WriteLine("Выберите действие: \n" +
                    "1. Создать книгу\n" +
                    "2. Вывести информацию о книгах\n" +
                    "3. Выход");

                int choice = Console.ReadKey(true).KeyChar - '0';

                Console.WriteLine();
                switch (choice)
                {
                    case 1: books.Add(Book.Input()); break;
                    case 2: OutputBooks(books); break;
                    case 3: return;
                }
                Console.WriteLine();
            }
        }

        public static void OutputBooks(List<Book> books)
        {
            foreach (Book book in books)
            {
                book.Output();
                Console.WriteLine();
            }
        }
    }
}
