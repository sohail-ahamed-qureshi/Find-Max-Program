using Find_Max_Program;
using NUnit.Framework;

namespace NunitFindMaxNumber.Test
{
    class MaxGeneric
    {
        /// <summary>
        /// testing for type integer numbers
        /// </summary>
        [Test]
        public void When_Given_IntergerFirstNumberMax_ReturnsSameNumber()
        {
            //Arrange
            int firstNumber = 1;
            int secondNumber = 0;
            int thirdNumber = -1;
            int expected = 1;

            //Act
            int result = FindMaxNumber.FindMax<int>(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// testing for type float numbers
        /// </summary>
        [Test]
        public void When_Given_floatSecondNumberMax_ReturnsSameNumber()
        {
            //Arrange
            float firstNumber = 12.22f;
            float secondNumber = 33.33f;
            float thirdNumber = 11.11f;
            float expected = 33.33f;

            //Act
            float result = FindMaxNumber.FindMax<float>(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void When_Given_StringThirdWordMax_ReturnsSameNumber()
        {
            //Arrange
            string firstNumber = "Apple";
            string secondNumber = "Ball";
            string thirdNumber = "Peach";
            string expected = "Peach";

            //Act
            string result = FindMaxNumber.FindMax<string>(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
