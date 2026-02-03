using System;

namespace AtlagSzamitas
{
    class Program
    {
        static void Main(string[] args)
        {
            // változók dekralása
            int a = 0, b = 0, c = 0, sum = 0;
            double avg;
            string InputText;

            Console.WriteLine("Adj meg 3 egész számot:");
            Console.WriteLine("Kiszámolom az átlagukat:");
            Console.WriteLine("Adj meg egy egész számot: ");
            InputText = Console.ReadLine();
            int.TryParse(InputText, out a);

            Console.Write("Adj meg még egy egész számot: ");
            InputText = Console.ReadLine();
            b = int.Parse(InputText);


            Console.Write("Adj meg még egy egész számot: ");
            InputText = Console.ReadLine();
            c = int.Parse(InputText);

            sum = a + b + c;

            avg = sum / 3;

            Console.WriteLine($"A 3 szám átlaga: {avg}");
            Console.WriteLine();
            Console.WriteLine("Enter-rel lehet kilépni!");
            Console.ReadLine(); //enter leütésére záródik csak be az ablak
            
        }

    }
}