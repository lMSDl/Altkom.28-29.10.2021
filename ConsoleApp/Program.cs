// USING - deklarujemy, że będziemu yżuwać klas spod wskazanego adresu (przestrzeni nazw)
using System;

// PRZESTRZEŃ NAZW - jest to swego rodzaju adres dla klas
namespace ConsoleApp
{
    // KLASA - opisuje zachowania i właściwości obiektów, które będą z niej wytwarzane
    class Program
    {
        // METODA - typ zwracany + nazwa + nawiasy + opcjonalne parametry + ciało
        // STATIC - oznacza, że jest to metoda niezależna (niezmienna) od instancji klasy
        static void Main(string[] args)
        {
            //wytworzenie obiektu klasy program
            var program = new Program();
            program.CalculateCircleArea();
        }

        void CalculateCircleArea()
        {
            Console.WriteLine("Podaj promień koła:");
            var inputR = Console.ReadLine();

            var r = float.Parse(inputR);

            var result = Math.PI * Math.Pow(r, 2);

            Console.WriteLine($"Pole wynosi: {result}");
        }


        void Numbers()
        {
            int a = 30;
            int b = 2;
            int c = 18;

            int d = a + b - 3 * c;
            Console.WriteLine(d);
            
            d = a / c;
            Console.WriteLine($"{a} / {c} = {d} reszty {a % c}");

            d = a + b / (c - a) * d;
            Console.WriteLine(d);

            Console.WriteLine($"int może przechowywać wartości od {int.MinValue} do {int.MaxValue}");

            d = int.MaxValue;
            d = d + 2;
            // int.MaxValue + 2 == int.MinValue + 1
            Console.WriteLine(d);

            Console.WriteLine($"short może przechowywać wartości od {short.MinValue} do {short.MaxValue}");
            Console.WriteLine($"long może przechowywać wartości od {long.MinValue} do {long.MaxValue}");
            Console.WriteLine($"uint może przechowywać wartości od {uint.MinValue} do {uint.MaxValue}");

            var intValue = 5;
            var longValue = 5L;
            var floatValue = 5f;
            var doubleValue = 5d;
            var decimalValue = 5M;

            //rzutowanie - zmiana typu na ten określony w nawiasach
            float f = (float)a / c;
            Console.WriteLine(f);
            double g = (double)a / c;
            Console.WriteLine(g);
            decimal h = (decimal)a / c;
            Console.WriteLine(h);

            Console.WriteLine($"float może przechowywać wartości od {float.MinValue} do {float.MaxValue}");
            Console.WriteLine($"double może przechowywać wartości od {double.MinValue} do {double.MaxValue}");
            Console.WriteLine($"decimal może przechowywać wartości od {decimal.MinValue} do {decimal.MaxValue}");

            var result = Math.PI * Math.Pow(a, 2) / 2;
            Console.WriteLine($"Połowa powierzchni koła o promieniu {a} = {result}");

            int largeValue = 1000000000;
            //zmiana typu na taki o wyższej precyzji/zakresie może odbywać się bez jawnego rzutowania
            long otherLargeValue = largeValue;

            Console.WriteLine(otherLargeValue);

            otherLargeValue = 10000000;
            //jawne rzutowanie wymagane w przypadku zmiany na typ o niższej precyzji/zakresie
            largeValue = (int)otherLargeValue;

            Console.WriteLine(largeValue);

        }

        void Strings()
        {
            //Deklaracja i inicjalizacja zmiennej lokalnej
            var helloString = "Hello";

            //Deklaracja zmiennej lokalnej - określenie typu + nazwa zmiennej
            string classString;
            //inicjalizacja zmiennej - pierwsze przypisanie wartości do zmiennej
            classString = "World";

            //helloString = helloString + classString;

            //przypisanie wartości do zmiennej
            classString = "Class";


            //Wywołanie metody statycznej z klasy Console
            Console.WriteLine(helloString + " " + classString + "!");
            Console.WriteLine("{0} {1}!\n{2} {3}!", helloString, classString, classString, helloString);

            //var - niejawna deklaracja typu. Typ określony jest poprzez inicjalizację (prawa strona przypisania wartości).
            var outputString = string.Format("{0} {1}!", helloString, classString);
            Console.WriteLine(outputString);

            //string interpolowany - uproszeczenie zapisu dla string.Format
            outputString = $"{helloString} {classString}!";
            Console.WriteLine(outputString);

            outputString = outputString.Replace("Hello", "Bye");
            Console.WriteLine(outputString);

            Console.WriteLine($"OutputString o treści \"{outputString.ToLower()}\" ma {outputString.Length} liter.");
        }
    }
}
