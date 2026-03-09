using System;

namespace Dog
{
    public class Dog
    {//Tulajdonságok (Properties)
        public string Color { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }


        //Konstruktor alapértelmezett értékekkel
        public Dog()
        {
            Color = "";
            Name = "";
            Breed = "";
            Height = 0;
            Weight = 0;
        }

        public Dog(string color, string name, string breed, double height, double weight)
        {
            this.Color = color;
            this.Name = name;
            this.Breed = breed;
            this.Height = height;
            this.Weight = weight;
        }

        // Metódusok (viselkedések)
        public void WagTail()
        {
            Console.WriteLine($"{Name} csóválja a farkát.");
        }

        public void Shit()
        {
            Console.WriteLine($"{Name} kupacot gyárt.");
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} ugat: Vau-vau.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} eszik.");
        }

        public void LieDown()
        {
            Console.WriteLine($"{Name} lefekszik.");
        }
        public void Shake()
        {
            Console.WriteLine($"{Name} megrázza magát.");
        }

        //ToString felülírás a könnyű kiíráshoz
        public override string ToString()
        {
            return $"Dog: {Name} ({Breed}), Color: {Color}, Height: {Height} cm ({Weight} kg)";
        }



        static void Main( string[] args)
        {//Bobby objektum létrehozása
            Dog bobby = new Dog();
            Dog rex = new Dog("Black","Rex","German Shephard", 50.0,60.0);
            bobby.Color = "Yellow Brown";
            bobby.Name = "Bobby";
            bobby.Breed = "Labrador";
            bobby.Height = 48.18;
            bobby.Weight = 10.89;

         //Bobby tulajdonságai és viselkedése
         Console.WriteLine(bobby); //kiírás

            bobby.WagTail();
            bobby.Bark();
            bobby.Eat();
            bobby.LieDown();
            bobby.Shake();
            bobby.Shit();

         Console.WriteLine(rex); //kiírás

            rex.WagTail();
            rex.Bark();
            rex.Eat();
            rex.LieDown();
            rex.Shake();
            rex.Shit();
        }
    }
}
