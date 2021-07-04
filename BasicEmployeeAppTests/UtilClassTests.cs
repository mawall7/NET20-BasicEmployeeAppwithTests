using BasicEmployeeAppwithTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEmployeeAppTests
{
    [TestClass]
    public class UtilClassTests
    {
        private Mock<IUI> ui;

        [TestInitialize] // runs before any test method
        public void Init()
        {
            ui = new Mock<IUI>();
            //Util.SetUp(ui.Object);
        }

        [TestMethod]
        public void AskForString_ShouldReturnString()
        {
            const string expected = "Kalle";
            ui.Setup(a => a.GetInput()).Returns(expected); //Obj Setup är för att sätta upp en fake metod för att slippa console readLine talar vi om vad som ska hända (SetUp och Setup är olika saker).

            var actual = Util.AskForString(expected, ui.Object); //i test så skrivs .Ojekt ut för att komma åt mockobjektet

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        [DataRow("5")]
        [DataRow("10")]
        [DataRow("15")]
                
        public void AskForInt_ReturneExpected(string value) // DataRow values to test 3 values no need for loop when using the attribute above 
        {
            ui.Setup(a => a.GetInput()).Returns(value);//GetInput method is redefined by mock setup called in Util.AskForInt()/AskedForString()
            var actual = Util.AskForInt(value, ui.Object);  

            Assert.AreEqual(int.Parse(value), actual);
        }

        [TestMethod]

        [DataRow("5")]
        [DataRow("10")]
        [DataRow("15")]


        public void AskForPositiveInt_ReturnExpected(string value)
        {
           
            ui.Setup(a => a.GetInput()).Returns(value);
           
            var actual = Util.AskForPositiveInt(value, ui.Object);

            Assert.AreEqual(int.Parse(value), actual);
        }
    }
}
