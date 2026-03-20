using System.Diagnostics;

namespace Fajlkezelo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = @"f:\Temp\szoveg.txt";

            try
            {
                // hiba védett kód a catch-ek miatt
                // Írás
                File.WriteAllText(fajl, "Első sor\nMásodik sor\n");

                // Olvasás
                string tartalom = File.ReadAllText(fajl);
                Console.WriteLine("Olvasott tartalom\n" + tartalom);

                // Hozzáfűzés
                File.AppendAllText(fajl, "Hozzáfűzött sor\n");
                Console.WriteLine("Hozzáfűzve!");
            }



            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Fájl nem található: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IO hiba: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Nincs jogosultság: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Váratlan hiba: {ex.Message}");
            }
        }
    }
}
