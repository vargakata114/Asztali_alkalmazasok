using Calculations;

namespace CalculationsTest
{
    public class CalculatorTest
    {
        [Fact]
        
        public void AddGiven1and2Returns3()
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var sum = calculator.Add(1, 2);
            //Assert
            Assert.Equal(3, sum);
        }

        [Fact]
        public void AddGivenTwoDecimalNumbersReturnsSum_FirstSet()
        {
            var calc = new Calculator();
            var result = calc.Add(1.1m, 2.2m);
            Assert.Equal(3.3m, result);
        }

        [Fact]
        public void IsOddTest1()
        {
            var calc = new Calculator();
            var result = calc.IsOdd(15);
            Assert.True(result);
        }

        [Fact]
        public void IsEvenTest1()
        {
            var calc = new Calculator();
            var result = calc.IsOdd(12);
            Assert.False(result);
        }

        [Fact]
        [Trait("Category","Fibo")]
        public void GetFibonacciDoesNotInclude0()
        {
            var calculator = new Calculator();
            var fibo = calculator.GetFibonacci(5);
            fibo = calculator.GetFibonacci(5);
            Assert.All(fibo, n => Assert.NotEqual(0, n));
        }
    }
}
