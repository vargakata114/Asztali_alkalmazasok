namespace NumbersGeneratorInterface
{
    public interface IGenerator
    {
        int Next();

        void Reset();
    }

    public class NaturalGenerator : IGenerator
    {
        public int maxElement = 10;
        public int minElement = 0;
        private int actualElement = -1;
        public int Next()
        {
            if (actualElement == -1)
            {
                actualElement = minElement;
                return actualElement;
            }
            Console.WriteLine("" + actualElement);
            actualElement++;
            return actualElement;
        }
        public void Reset()
        {
            actualElement = 0;
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
