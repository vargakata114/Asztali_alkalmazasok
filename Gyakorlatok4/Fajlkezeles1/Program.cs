using System.IO;

namespace Fajlkezeles1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path= "teszt.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("A {0} nevű fájl létezik!", path);
                File.WriteAllText(path, "Hello, File Handling in C#!");
            }
            else
            {
                Console.WriteLine("A {0} nevű fájl nem létezik!", path);
                File.WriteAllText(path, "Hello, File Handling in C#!");
            }

        }
    }
}
