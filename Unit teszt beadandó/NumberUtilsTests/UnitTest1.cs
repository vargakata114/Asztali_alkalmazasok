using Xunit;
using System;
using NumberLibrary;

namespace NumberLibrary
{
    public class NumberUtilsTests
    {
        private NumberUtils utils = new NumberUtils();

        [Fact]
        public void Add_Test()
        {
            Assert.Equal(5, utils.Add(2, 3));
        }

        [Fact]
        public void Subtract_Test()
        {
            Assert.Equal(1, utils.Subtract(3, 2));
        }

        [Fact]
        public void Multiply_Test()
        {
            Assert.Equal(6, utils.Multiply(2, 3));
        }

        [Fact]
        public void Divide_Test()
        {
            Assert.Equal(2, utils.Divide(4, 2));
        }

        [Fact]
        public void Divide_ByZero_ShouldThrow()
        {
            Assert.Throws<DivideByZeroException>(() => utils.Divide(4, 0));
        }

        [Fact]
        public void Square_Test()
        {
            Assert.Equal(9, utils.Square(3));
        }

        [Fact]
        public void Abs_Test()
        {
            Assert.Equal(5, utils.Abs(-5));
        }

        [Fact]
        public void Max_Test()
        {
            Assert.Equal(10, utils.Max(10, 5));
        }

        [Fact]
        public void Min_Test()
        {
            Assert.Equal(5, utils.Min(10, 5));
        }

        [Fact]
        public void IsEven_Test()
        {
            Assert.True(utils.IsEven(4));
            Assert.False(utils.IsEven(5));
        }

        [Fact]
        public void Factorial_Test()
        {
            Assert.Equal(120, utils.Factorial(5));
        }

        [Fact]
        public void Factorial_Negative_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => utils.Factorial(-1));
        }

        [Fact]
        public void Average_Test()
        {
            int[] arr = { 2, 4, 6 };
            Assert.Equal(4, utils.Average(arr));
        }

        [Fact]
        public void Average_Empty_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => utils.Average(new int[] { }));
        }
    }
}