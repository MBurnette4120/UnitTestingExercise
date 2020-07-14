using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(4,5,6,15)]
        [InlineData (300,300,200,800)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1,2,-1)]
        [InlineData(10, 2, 8)]
        [InlineData(200, 100, 100)]
        [InlineData(0, 100, -100)]

        public void Sub(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Sub(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,1,5)]
        [InlineData(10, 10, 100)]
        [InlineData(20, -5, -100)]
        [InlineData(5, 0, 0)]
        
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Mult(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(100,20,5)]
        [InlineData(40, 2, 20)]
        [InlineData(99, 3, 33)]
        [InlineData(-300, 3, -100)]
        [InlineData(0, 20, null)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Div(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
