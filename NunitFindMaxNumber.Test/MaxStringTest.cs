using Find_Max_Program;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitFindMaxNumber.Test
{
    class MaxStringTest
    {
        [Test]
        public void When_Given_FirstStringMax_ReturnsSameNumber()
        {
            //Arrange
            string firstNumber = "Sohail";
            string secondNumber = "Ahamed";
            string thirdNumber = "Qureshi";
            string expected = "Sohail";

            //Act
            string result = FindMaxNumber.FindMax(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void When_Given_SecondStringMax_ReturnsSameNumber()
        {
            //Arrange
            string firstNumber = "Apple";
            string secondNumber = "Cat";
            string thirdNumber = "ballz";
            string expected = "Cat";

            //Act
            string result = FindMaxNumber.FindMax(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void When_Given_ThirdStringMax_ReturnsSameNumber()
        {
            //Arrange
            string firstNumber = "Rohan";
            string secondNumber = "Umbrella";
            string thirdNumber = "ZZebra";
            string expected = "ZZebra";

            //Act
            string result = FindMaxNumber.FindMax(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
