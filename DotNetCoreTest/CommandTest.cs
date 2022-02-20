using DotNetCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DotNetCoreTest
{
    public class CommandTest : IDisposable
    {

        Command testCommand;
        public CommandTest()
        {
            testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                Line = "dotnet test"
            };
        }


        [Fact]
        public void CanChangeHowTo()
        {
            //Act
            testCommand.HowTo = "Execute Unit Tests";
            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Act
            testCommand.Platform = "xunit";
            //Assert
            Assert.Equal("xunit", testCommand.Platform);
        }

        public void Dispose()
        {
            testCommand = null;
        }
    }
}
