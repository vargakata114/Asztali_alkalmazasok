namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton obj1 = Singleton.GetInstance();
            Singleton obj2 = Singleton.GetInstance();
            if (obj1.Equals(obj2))
            {
                Console.WriteLine("Obj1 and obj2 are the same instance.");
            }
            else
            {
                Console.WriteLine("Obj1 and obj2 are different instances.");
            }
        }
    }
}
