using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UMLGyak4
{

    public interface Jatekgep
    {
        public void Jatszik();
        public bool Jackpot();
    }


    public class Gep
    {
        private string name = "";
        private int kredit = 0;

        public virtual string ToString()
        {
            return name;
        }
    }


    public class Dobokocka : Gep, Jatekgep
    {
        private int[] dobokockak;
        public void Jatszik()
        {
            Console.WriteLine("Játszik metódus");
        }

        public bool Jackpot()
        {
            Console.WriteLine("Jackpot metódus");
            return true;
        }

        public override string ToString()
        {
            return ("");
        }
    }

    public class Szamitogep : Gep, Jatekgep
    {
        private Random rnd = new Random();


        public void Jatszik()
        {
            Console.WriteLine("Játszik metódus");
        }

        public bool Jackpot()
        {
            Console.WriteLine("Jackpot metódus");
            return true;
        }

        public override string ToString()
        {
            return ("");
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
