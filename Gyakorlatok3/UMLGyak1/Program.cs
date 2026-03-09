namespace UMLGyak1
{
    public class Animal
    {
        public int age = 0;
        public string gender = "";

        public bool isMammal()
        {
            return false;
        }

        public void mate()
        {

        }
    }

    public class Duck : Animal
    {
        public string beakColor = "red";
        public void swim()
        {

        }
        public void quack()
        {

        }

    }


    public class Fish: Animal
    {
        private int sizeInFeet = 0;
        private bool canEat()
        {
            return false;
        }
    }


    public class Zebra: Animal
    {
        private bool is_wild = false;

        public void run()
        {

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
