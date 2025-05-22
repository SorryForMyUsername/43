using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_2
{
    internal struct Notebook
    {
        public string model;
        public string manufacturer;
        public int price;

        public Notebook(string model, string manufacturer, int price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void Output()
        {
            Console.WriteLine($"Модель: {model}\n" +
                $"Производитель: {manufacturer}\n" +
                $"Цена: {price}");
        }
    }
}
