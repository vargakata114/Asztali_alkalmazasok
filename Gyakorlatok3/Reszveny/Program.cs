namespace Reszveny
{
    public class Reszveny
    {
        // mezők, belső változók, properties
        private readonly string reszvenynev;
        private double reszvenyarfolyam = 0.0;
        public int Darabszam;

        public Reszveny(string nev, double arfolyam, int darabszam)
        {//Konstruktor (neve megegyezik az osztály nevével) - beállítja az adatmezők kezdet értékét
            reszvenynev = nev;
            reszvenyarfolyam = arfolyam;
            Darabszam = darabszam;
        }

        public void Vetel(int mennyiseg)
        { // A paraméterben megadott mennyiségű részvény vásárlása
            //Darabszam -= mennyiseg;
            Darabszam = Darabszam + mennyiseg;
        }

        public void Eladas(int mennyiseg)
        { // A paraméterben megadott mennyiségű részvény eladása
            //Darabszam -= mennyiseg;
            if (Darabszam >= mennyiseg)
            {
                Darabszam = Darabszam - mennyiseg;
            }
            else
            {
                Console.WriteLine("Nincs annyi részvényem!!!");
            }

        }

        public void ArfolyamBeallitas(double arfolyam)
        { // Az aktuális árfolyam beálltása a paraméterben megadott árfolyam alapján
            reszvenyarfolyam = arfolyam;
        }

        public double Ertek()
        { // Részvény összértékének kiszámítása
            return reszvenyarfolyam * Darabszam;
        }

        ~Reszveny()
        {
            Console.WriteLine("Destruktor meghívódott!!");
        }
    }

    internal class Program
    {
       static void Main(string[] args)
       {
            Reszveny IBM = new Reszveny("IBM", 77.59, 100);
            Reszveny nVidia = new Reszveny("NVIDIA", 21.491, 100);

            //IBM.Darabszam = 23;
            //IBM.reszvenyarfolyam = 24.23;
            IBM.Vetel(50);
            nVidia.Vetel(25);
            nVidia.ArfolyamBeallitas(29.15);
            nVidia.Eladas(50);
            Console.Write("Az IBM részvényeim értéke: " + nVidia.Ertek());
            Console.WriteLine();
            Console.Write("Az nVidia részvényeim értéke: " + IBM.Ertek());

        }
    }
}