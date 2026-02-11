namespace Metodus4
{
    internal class Program
    {
        static bool Szamfelbontas(string szoveg, out int harmasok, out int parosak)
        {
            harmasok = 0;
            parosak = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i  % 3 == 0) harmasok++;
                if (i % 2 == 1) parosak++;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int e, p;
            bool retVal;
            Console.WriteLine("=== OUT paraméter ===");
            retVal = Szamfelbontas("nem fontos", out e, out p);
            if (retVal)
            {
                Console.WriteLine($"0-100: {e} db 3-mal osztható, {p} db páros");
            }
        }
    }
}
