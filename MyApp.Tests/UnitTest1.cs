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
            Assert.True(is400LY);
        }

        [Fact]
        public void is1700LeapYear()
        {
            //Arrange
            var myApp = new Year();
            //Act
            var is1700LY = myApp.IsLeapYear(1700);
            //Assert
            Assert.False(is1700LY);
        }

        [Fact]
        public void is1800LeapYear()
        {
            //Arrange
            var myApp = new Year();
            //Act
            var is1800LY = myApp.IsLeapYear(1800);
            //Assert
            Assert.False(is1800LY);
        }

        [Fact]
        public void is1900LeapYear()
        {
            //Arrange
            var myApp = new Year();
            //Act
            var is1900LY = myApp.IsLeapYear(1900);
            //Assert
            Assert.False(is1900LY);
        }

        [Fact]
        public void is1600LeapYear()
        {
            //Arrange
            var myApp = new Year();
            //Act
            var isLY = myApp.IsLeapYear(1600);
            //Assert
            Assert.True(isLY);
        }

        [Fact]
        public void is2000LeapYear()
        {
            //Arrange
            var myApp = new Year();
            //Act
            var isLY = myApp.IsLeapYear(2000);
            //Assert
            Assert.True(isLY);
        }

        [Fact]
        public void is1600LeapYearString()
        {
            /*//Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);*/
            //Act
            //Assert
            Assert.Equal("yay", Program.IsLeapYearToString(1600));

        }

        [Fact]
        public void is1600LeapYearError()
        {
            /*//Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);*/
            //Act
            //Assert
            Assert.Equal("yay", Program.IsLeapYearErrors("1600"));

        }

        [Fact]
        public void is1500LeapYearError()
        {
            /*//Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);*/
            //Act
            //Assert
            Assert.Equal("You have to enter a year after 1582", Program.IsLeapYearErrors("1500"));

        }

        [Fact]
        public void isLettersLeapYearError()
        {
            /*//Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);*/
            //Act
            //Assert
            Assert.Contains("Exception caught.\n\r Please type a year", Program.IsLeapYearErrors("asdf"));

        }
    }

   
}
