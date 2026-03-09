using System.Linq.Expressions;

namespace Kerteszet
{
    interface INoveny
    {
        public const int VIZ_AR = 150; // A publicot nem kötelező kiírni, mert az interfacebe minden public alapból is
        double NapiVizfogyasztas(); // Az abstract ugyan ez, alapból nem kell megadni, mert az lesz

    }

    public abstract class Noveny : INoveny
    {
        protected bool ritka;
        private double magassag;
        public Noveny(double magassag, bool ritka)
        {
            this.magassag = magassag;
            this.ritka = ritka;
        }
        public abstract void Novekszik();
        public double NapiVizfogyasztas()
        {
            double alap = magassag * INoveny.VIZ_AR;
            if (ritka == true) return alap * 1.5;
            else return alap;
        }

        public override string ToString()
        {
            string statusz = ritka ? "Ritka" : "Közönséges";
            return magassag + " m - " + statusz + " - " + NapiVizfogyasztas() + "Ft/Nap";
        }

    }

    class RekaFA : Noveny
    {
        public RekaFA(double magassag, bool ritka) : base(magassag, ritka) { }
        public override void Novekszik()
        {
            Console.WriteLine("A Réka fa lassan növekszik a vízparton.");
        }
    }

    class Kaktusz : INoveny
    {
        private bool viragszoru;
        public Kaktusz(bool viragszoru)
        {
            this.viragszoru = viragszoru;
        }

        public double NapiVizfogyasztas()
        {
            double szoro = viragszoru ? 0.3 : 0.1;
            return szoro * INoveny.VIZ_AR;
        }

        public override string ToString()
        {
            string nev = viragszoru ? "Virágzó kaktusz" : "Normál kaktusz";
            return nev + " - " + NapiVizfogyasztas() + "Ft/nap";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<INoveny> lista = new List<INoveny>();

            lista.Add(new RekaFA(15, false));
            lista.Add(new RekaFA(12, true));
            lista.Add(new Kaktusz(true));
            lista.Add(new Kaktusz(false));

            foreach (INoveny elem in lista)
            {
                Console.WriteLine(elem.ToString());
                if (elem is RekaFA rekaFa)
                {
                    rekaFa.Novekszik();
                }
            }
            Console.ReadLine();
               
;       }
    }
}
