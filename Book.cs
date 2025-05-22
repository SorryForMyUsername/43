using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_3
{
    internal struct Book
    {
        public string title;
        public string author;
        public int publicationYear;
        int pages;

        public Book(string title, string author, int publicationYear, int pages)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.pages = pages;
        }

        public void Output()
        {
            Console.WriteLine($"Название: {title}\n" +
                $"Ф.И.О автора: {author}\n" +
                $"Год издания: {publicationYear}\n" +
                $"Количество страниц: {pages}");
        }

        public static Book Input()
        {
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Ф.И.О. автора: ");
            string author = Console.ReadLine();
            Console.Write("Год издания: ");
            int publicationYear = int.Parse(Console.ReadLine());
            Console.Write("Кол-во страниц: ");
            int pages = int.Parse(Console.ReadLine());

            return new Book(title, author, publicationYear, pages);
        }
    }
}
