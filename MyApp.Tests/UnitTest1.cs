using System;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void is400LeapYear()
        {
            //Arrange
            var myApp = new Year();
            //Act
            var is400LY = myApp.IsLeapYear(400);
            //Assert
            Assert.Equal(true, is400LY);
        }

        [Fact]
        public void is1700LeapYear()
        {
            //Arrange
            var myApp = new Year();
            //Act
            var is1700LY = myApp.IsLeapYear(1700);
            //Assert
            Assert.Equal(false, is1700LY);
        }

        [Fact]
        public void is1800LeapYear()
        {
            //Arrange
            var myApp = new Year();
            //Act
            var is1800LY = myApp.IsLeapYear(1800);
            //Assert
            Assert.Equal(false, is1800LY);
        }

        [Fact]
        public void is1900LeapYear()
        {
            //Arrange
            var myApp = new Year();
            //Act
            var is1900LY = myApp.IsLeapYear(1900);
            //Assert
            Assert.Equal(false, is1900LY);
        }

        [Fact]
        public void is1600LeapYear()
        {
            //Arrange
            var myApp = new Year();
            //Act
            var isLY = myApp.IsLeapYear(1600);
            //Assert
            Assert.Equal(true, isLY);
        }

        [Fact]
        public void is2000LeapYear()
        {
            //Arrange
            var myApp = new Year();
            //Act
            var isLY = myApp.IsLeapYear(2000);
            //Assert
            Assert.Equal(true, isLY);
        }
    }
}
