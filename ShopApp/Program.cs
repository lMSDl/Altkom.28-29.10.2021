using System;
using System.Collections.Generic;
using Models;

namespace ShopApp
{
    class Program
    {
        List<Product> Products { get; set; }

        static void Main(string[] args)
        {
            new Test().Execute();

            var program = new Program();
            program.Products = new List<Product>();
            program.AddInitialProducts();
            program.ShowProducts();

            bool exit = false;
            do
            {
                Console.Clear();
                program.ShowProducts();

                Console.WriteLine("1. Add; 2. Edit; 3. Delete; 4. Exit");
                var input = Console.ReadLine();

                //switch - alternatywa dla rozbudowanego if-elseif. Porównuje wartość w nawiasie do wartości przy case. Default - zachowanie domyślne, jeśli żaden case nie pasuje do parametru.
                switch (input)
                {
                    case "1":
                        program.Add();
                        break;
                    case "2":
                        program.Edit();
                        break;
                    case "3":
                        program.Delete();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Błędny wybór");
                        Console.WriteLine("Naciśniej dowolny przycisk...");
                        Console.ReadKey();
                        break;
                } 
            } while (!exit);
        }

        void Add()
        {
            var product = new Product();
            EditProduct(product);
            Products.Add(product);
        }
        void Edit()
        {
            var index = GetIndex();
            var product = Products[index];
            EditProduct(product);
        }

        int GetIndex()
        {
            Console.WriteLine("Podaj indeks:");
            var input = Console.ReadLine();
            try
            {
                var index = int.Parse(input);
                return index;
            }
            catch
            {
                Console.WriteLine("Błędny indeks");
                Console.WriteLine("Naciśniej dowolny przycisk...");
                Console.ReadKey();
                return -1;
            }
        }

        void Delete()
        {
            var index = GetIndex();
            //var product = Products[index];
            //Products.Remove(product);
            Products.RemoveAt(index);
        }

        void ShowProducts()
        {
            //for (int i = 0; i < Products.Count; i++)
            foreach(var product in Products)
            {
                //Console.WriteLine(Products[i]);
                Console.WriteLine(product) ;
            }
        }

        void AddInitialProducts()
        {
            //inicjalizator (to w nawiasach klamrowych) - pozwala zainicjować publiczne właściwości
            var product1 = new Product(DateTime.Now.AddDays(5)) { Name = "masło", Price = 5.34M, Category = Category.Food };
            Products.Add(product1);

            var product2 = new Product() { Category = 0 };
            EditProduct(product2);
            Products.Add(product2);
        }

        void EditProduct(Product product)
        {
            Console.WriteLine("Podaj nazwę produktu:");
            product.Name = Console.ReadLine();

            Console.WriteLine("Podaj kategorię:");
            product.Category = (Category)Enum.Parse(typeof(Category), Console.ReadLine(), true);

            do
            {
                Console.WriteLine("Podaj cenę produktu:");
                if (decimal.TryParse(Console.ReadLine(), out var price))
                {
                    product.Price = price;
                }
                else
                {
                    Console.WriteLine("Błędna cena");
                }
            } while (product.Price == 0);

            Console.WriteLine("Data ważności:");
            product.ExpirationDate = DateTime.Parse(Console.ReadLine());
        }
    }
}
