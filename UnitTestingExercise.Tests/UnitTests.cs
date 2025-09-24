using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(20, 1, 37, 58)]
        [InlineData(67, 114, 25, 206)]
        [InlineData(9, 524, 748, 1281)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            Calculator solver = new Calculator();
            

            //Act
            var actual = solver.Add(num1, num2, num3);
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 6, 2)]
        [InlineData(220,20, 200)]
        [InlineData(357, 119, 238)]
        [InlineData(36, 9, 27)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator difference = new Calculator();

            //Act
            var actual = difference.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 14, 56)]
        [InlineData(5, 20, 100)]
        [InlineData(15, 3, 45)]
        [InlineData(64,32,2048)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator solver = new Calculator();

            //Act
            var actual = solver.Multiples(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(60, 4, 15)]
        [InlineData(651, 21, 31)]
        [InlineData(45, 9, 5)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator solver = new Calculator();

            //Act
            var actual = solver.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
