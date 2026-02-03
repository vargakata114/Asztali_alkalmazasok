using System;

namespace Szamtalalo
{
    class Program
    {
        static void Main(string[] arp)
        {
            //véletlenszám generátor objektum használata
            Random r = new Random();
            int veletlenSzam = r.Next(1, 100);
            int tipp = 0;
            bool eltalaltuk = false;
            string inputText = "";

            /* while()
            {
            }
            */

            // do-while verzióval
            do
            {
                Console.WriteLine("Kérek egy tippet:");
                inputText = Console.ReadLine();
                tipp = int.Parse(inputText);
                if (tipp < veletlenSzam)
                {
                    Console.Write("A szám nagyobb, mint a tipp volt!");
                }
                else
                {
                    if (tipp > veletlenSzam)
                     { 
                        Console.Write("A szám kisebb, mint a tipp volt!");
                    }
                    else
                    {
                        Console.Write("Eltaláltad!");
                        eltalaltuk=true;
                    }
                    
                }
            }
            while (!eltalaltuk);

            
            //Console.WriteLine($"Egy véletlen szám: {r.Next(1,100)}");
            Console.WriteLine();
            Console.WriteLine("Enter-rel lehet kilépni!");
            Console.ReadLine();
            
        }
    }
}