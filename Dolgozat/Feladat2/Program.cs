namespace Feladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            double x1 = 0, x2 = 0;
            string inputText = null;
            Console.WriteLine("==== Másodfokú egyenlet megoldása ====");
            Console.Write("Kérem az (A) együtthatót: ");
            inputText = Console.ReadLine();
            //a = double.Parse(inputText);
            //a = Convert.ToDouble(inputText);
            double.TryParse(inputText, out a);
            Console.Write("Kérem a (B) eggyütthatót: ");
            inputText = Console.ReadLine();
            double.TryParse(inputText, out b);
            Console.Write("Kérem a (C) eggyütthatót: ");
            inputText = Console.ReadLine();
            double.TryParse(inputText, out c);
            x1 = (-1 * b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            x2 = (-1 * b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            Console.WriteLine($"Az x1 megoldása: {x1}");
            Console.WriteLine($"Az x2 megoldása: {x2}");
        }
    }
}
