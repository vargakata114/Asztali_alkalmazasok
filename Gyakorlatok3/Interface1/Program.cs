namespace Interface1
{
    internal class Program
    {
        public interface IAnimal
        {
            //public int age = 0;
            //public string gender;

            public bool isMammal()
            {
                return false;
            }

            public void mate()
            {

            }
            public void swim()
            {

            }
            public void quack()
            {

            }


            public class Duck : IAnimal
            {
                public string beakColor = "red";
                public void swim()
                {
                    Console.WriteLine("Duck is swimming.");
                }
                public void quack()
                {
                    Console.WriteLine("Duck is quacking.");
                }

            }


            public class Fish : IAnimal
            {
                private int sizeInFeet = 0;
                private bool canEat()
                {
                    return false;
                }
                public void swim()
                {
                    Console.WriteLine("Fish is swimming.");
                }
                public void quack()
                {
                    throw new NotImplementedException();
                    //Console.WriteLine("Duck is quacking.");
                }
            }


            static void Main(string[] args)
            {
                IAnimal animal = new Duck();
                animal.swim();
                animal.quack();
                //Duck duck = new Duck();
                //duck.swim();
                //duck.quack();

                Fish fish = new Fish();
                fish.swim();
                //fish.quack();
            }
        }
    }

}
