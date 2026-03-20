namespace Fajlkezelo2
{
    internal class Program
    {
        static void Main()
        {
            string fajl = "szoveg.txt";

            // Írás
            using (StreamWriter sw = File.CreateText(fajl))
            {
                sw.WriteLine("Első sor");
                sw.WriteLine("Második sor");
            }

            // Olvas
            using (StreamReader sr = File.OpenText(fajl))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    Console.WriteLine(sor);
                }
            }


            // Hozzáfűzés
            using (StreamWriter sw = File.CreateText(fajl))
            {
                sw.WriteLine("Hozzáfűződott sor");
            }





            Console.WriteLine("Hello, World!");
        }
    }
}
