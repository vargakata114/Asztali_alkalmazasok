namespace Alakzatok
{
    public class Circle
    {
        private double r = 0;
        public Circle(double r) {
            this.r = r;
        }

        public double Terulet()
        {
            return Math.PI * r * r;
        }

        public double Kerulet()
        {
            return Math.PI * 2 * r;
        }

        public void Kiir()
        {
            Console.WriteLine($"Kör, sugár: {this.r}");
        }
    }


    public class Rectangle
    {
        private double a = 0;
        private double b = 0;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Terulet()
        {
            return a * b;
        }

        public double Kerulet()
        {
            return 2 * (a + b);
        }

        public void Kiir()
        {
            Console.WriteLine($"Téglalap, a: {this.a}, b: {this.b}");
        }
    }


    public class Square
    {
        private double a = 0;
        public Square(double a)
        {
            this.a = a;
        }

        public double Terulet()
        {
            return a * a;
        }

        public double Kerulet()
        {
            return 4 * a;
        }

        public void Kiir()
        {
            Console.WriteLine($"Négyzet, a: {this.a}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Circle kor = new Circle(67.34);
            kor.Kiir();
            Console.Write("A kör területe: " + kor.Terulet());
            Console.WriteLine();
            Console.WriteLine("A kör kerülete: " + kor.Kerulet());
            Console.WriteLine(kor);


            Square negyzet = new Square(101.34);
            negyzet.Kiir();
            Console.Write("A négyzet területe: " + negyzet.Terulet());
            Console.WriteLine();
            Console.WriteLine("A négyzet kerülete: " + negyzet.Kerulet());
            Console.WriteLine(negyzet);


            Rectangle teglalap = new Rectangle(34.12,56.11);
            teglalap.Kiir();
            Console.Write("A téglalap területe: " + teglalap.Terulet());
            Console.WriteLine();
            Console.WriteLine("A téglalap kerülete: " + teglalap.Kerulet());
            Console.WriteLine(teglalap);
        }
    }
}
