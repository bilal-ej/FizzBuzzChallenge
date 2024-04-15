using FizzBuzzChallenge.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Assert = Xunit.Assert;

namespace FizzBuzzChallenge.UnitTests.FizzBuzzServiceTests
{
    [TestClass]
    public class FizzBuzzServiceUnitTests
    {
        private readonly FizzBuzzService _sut;

        public FizzBuzzServiceUnitTests()
        {
            _sut = new FizzBuzzService();
        }


        [Theory]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(21)]
        public void DoFizzBuzz_WhenDivisibleByThreeOnly_ReturnFizz(int number)
        {
            //Arrange
            string expectedOutput = "Fizz";
            //Act
            var actualOutput = _sut.GetFizzBuzzMessage(number);
            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(25)]
        [InlineData(35)]
        public void DoFizzBuzz_WhenDivisibleByFiveOnly_ReturnBuzz(int number)
        {
            //Arrange
            string expectedOutput = "Buzz";
            //Act
            var actualOutput = _sut.GetFizzBuzzMessage(number);
            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        public void DoFizzBuzz_WhenDivisibleByThreeAndFive_ReturnFizzBuzz(int number)
        {
            //Arrange
            string expectedOutput = "FizzBuzz";
            //Act
            var actualOutput = _sut.GetFizzBuzzMessage(number);
            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }



    }
}
