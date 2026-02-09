namespace Metodus3
{
    internal class Program
    {
        // ÉRTÉK szerinti átadás (másolat)
        static void ErtekAtadas(int szam)
        {
            szam = 999;
            Console.WriteLine($"Belső: {szam}");
        }

        // REFERENCIA szerinti átadás (ref)
        static void RefAtadas(ref int szam)
        {
            szam = 888;
            Console.WriteLine($"Belső ref: {szam}");
        }
        static void Main(string[] args)
        {
            int ertek = 123;

            Console.WriteLine("=== ÉRTÉK ÁTADÁS ===");
            Console.WriteLine($"Külső előtte: {ertek}");
            ErtekAtadas(ertek);
            Console.WriteLine($"Külső utána: {ertek}");   // 123 marad!

            Console.WriteLine("\n=== REFERENCIA ÁTADÁS ===");
            Console.WriteLine($"Külső előtte: {ertek}");
            RefAtadas(ref ertek);
            Console.WriteLine($"Külső utána: {ertek}");   // 888 lesz!
        }
    }
}
