using System;
using Models;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicjalizator (to w nawiasach klamrowych) - pozwala zainicjować publiczne właściwości
            var product1 = new Product(DateTime.Now.AddDays(5)) { Name = "masło", Price = 5.34M, Category = Category.Food };

            var product2 = new Product() { Category = 0};

            Console.WriteLine("Podaj nazwę produktu:");
            product2.Name = Console.ReadLine();

            product2.Category = (Category)Enum.Parse(typeof(Category) ,Console.ReadLine());

            do
            {
                Console.WriteLine("Podaj cenę produktu:");
                if (decimal.TryParse(Console.ReadLine(), out var price))
                {
                    product2.Price = price;
                }
                else
                {
                    Console.WriteLine("Błędna cena");
                }
            } while (product2.Price == 0);

            Console.WriteLine(product1);
            Console.WriteLine(product2);

        }


    }
}
