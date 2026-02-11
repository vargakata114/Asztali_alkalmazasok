namespace Feladat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elso = 0;
            int masodik = 0;
            string inputText = null;
            Console.WriteLine("Egész számok hányadosának kiszámítása");
            Console.WriteLine("Kérem az első egész számot: ");
            inputText = Console.ReadLine();
            //elso = int.Parse(inputText);
            int.TryParse(inputText, out elso);
            elso = Convert.ToInt32(inputText);
            Console.WriteLine("Kérem a második egész számot: ");
            inputText = Console.ReadLine();
            masodik = Convert.ToInt32(inputText);
            Console.WriteLine($"A számok hányadosa: {(double)elso/masodik:F2} ");
        }
    }
}
