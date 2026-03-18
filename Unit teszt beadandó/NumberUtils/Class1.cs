using System;

namespace NumberLibrary
{
    public class NumberUtils
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        
        public int Subtract(int a, int b)
        {
            return a - b;
        }
 

        public int Multiply(int a, int b)
        {
            return a * b;
        }

       
        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Nem lehet nullával osztani!");

            return (double)a / b;
        }

      
        public int Square(int a)
        {
            return a * a;
        }

     
        public int Abs(int a)
        {
            if (a < 0)
                return -a;
            return a;
        }

       
        public int Max(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }

     
        public int Min(int a, int b)
        {
            if (a < b)
                return a;
            return b;
        }

    
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

       
        public int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Negatív számra nincs faktoriális!");

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }


        public double Average(int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Üres tömb!");

            int sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }

            return (double)sum / numbers.Length;
        }
    }
}