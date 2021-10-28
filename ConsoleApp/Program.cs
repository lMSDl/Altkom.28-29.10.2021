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
