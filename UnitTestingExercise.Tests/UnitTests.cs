using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
         [InlineData("hello", false)]
         [InlineData("123321", true)]
         [InlineData("45654", true)]
         [InlineData("racecar", true)]

        public void PalindromeTester(string word, bool expected)
        {
            // Arrange
            var ws = new WordSmith();

            // Action
            var actual = ws.IsAPalindrome(word);

            // Assert
            Assert.Equal(actual, expected);
        }
        
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(-1,2,3,4)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var funcs = new NumFunctions();

            //Act
            var actual = funcs.Add3Ints(num1, num2, num3);

            //Assert
            Assert.Equal(actual, expected);
        }
        
        [Theory]
        [InlineData(10, -5, 15)]
        [InlineData(10, 5, 5)]
        [InlineData(5, 10, -5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var funcs = new NumFunctions();

            //Act
            var actual = funcs.Minus(minuend, subtrhend);

            //Assert
            Assert.Equal(actual, expected);

        }
        
        [Theory]
        [InlineData(10, -5, -50)]
        [InlineData(10, 5, 50)]
        [InlineData(10, 100, 1000)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var funcs = new NumFunctions();

            //Act
            var actual = funcs.Mult(num1, num2);

            //Assert
            Assert.Equal(actual, expected);

        }
        
        [Theory]
        [InlineData(10, -5, -2)]
        [InlineData(10, 5, 2)]
        [InlineData(10, 100, 0.1)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var funcs = new NumFunctions();

            //Act
            var actual = funcs.Ratio(num1, num2);

            //Assert
            Assert.Equal(actual, expected);

        }
        /*
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
        */
    }
}
