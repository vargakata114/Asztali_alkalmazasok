namespace Abstract1
{
    public abstract class Animal
    {
        public int age = 0;
        public string gender = "";

        public abstract bool isMammal();

        public abstract void mate();

    }

    public class Duck : Animal
    {
        public string beakColor = "red";

        public override bool isMammal()
        {
            Console.WriteLine("Duck isMammal is called.");
            return true;
        }
        public override void mate()
        {
            Console.WriteLine("Duck has a mate.");
        }
        public void swim()
        {

        }
        public void quack()
        {

        }

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Duck duck = new Duck();
            duck.mate();
            duck.isMammal();
            Console.WriteLine("Hello, World!");
        }
    }
}