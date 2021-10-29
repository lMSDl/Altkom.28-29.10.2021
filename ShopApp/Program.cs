using System;
using Models;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicjalizator (to w nawiasach klamrowych) - pozwala zainicjować publiczne właściwości
            var prodcut1 = new Product(DateTime.Now.AddDays(5)) { Name = "masło", Price = 5.34M };

            var prodcut2 = new Product();

            Console.WriteLine("Podaj nazwę produktu:");
            prodcut2.Name = Console.ReadLine();

            do
            {
                Console.WriteLine("Podaj cenę produktu:");
                if (decimal.TryParse(Console.ReadLine(), out var price))
                {
                    prodcut2.Price = price;
                }
                else
                {
                    Console.WriteLine("Błędna cena");
                }
            } while (prodcut2.Price == 0);

            Console.WriteLine(prodcut1);
            Console.WriteLine(prodcut2);
        }
    }
}
