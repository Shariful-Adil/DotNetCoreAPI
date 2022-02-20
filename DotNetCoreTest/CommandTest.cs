using DotNetCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DotNetCoreTest
{
    public class CommandTest
    {
        [Fact]
        public void CanChangeHowTo()
        {
        //Arrange
            var testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                Line = "dotnet test"
            };

            //Act
            testCommand.HowTo = "Execute Unit Tests";
            testCommand.Platform = "xunit";
            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
            Assert.Equal("xunit", testCommand.Platform);
        }
    }
}
