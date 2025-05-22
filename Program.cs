using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Модель", "Производитель", 100);
            notebook.Output();

            Console.ReadKey();
        }
    }
}
