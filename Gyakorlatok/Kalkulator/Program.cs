namespace Kalkulator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Add\n2. Subtract\n3. Multiply\n4. Division");
            //char choice = (char)Console.ReadLine();
            //int choice = int.Parse(Console.ReadLine());
            //string choice = Console.ReadLine(); 
            float choice = float.Parse(Console.ReadLine());
            int a = 10, b = 5;
            switch (choice) 
            {
                case 1:
                    Console.WriteLine("Sum: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Difference: " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Product: " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Quotient: " + (a / b));
                    break;
                default:
                    Console.WriteLine("Inavlid choice");
                    break;
            }

        }
    }
}
