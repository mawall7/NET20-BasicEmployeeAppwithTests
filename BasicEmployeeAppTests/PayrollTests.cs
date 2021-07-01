using BasicEmployeeAppwithTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEmployeeAppTests
{
    [TestClass]
    public class PayrollTests
    {
        [TestMethod]
        public void ShouldReturn_Object()
        {
            var payroll = new Payroll();
            var actual = payroll.GetEmployees();

            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void AddEmployee_Should_Add()
        {
            var payroll = new Payroll();

            var expectedName = "Kalle";
            var expectedSalary = 10000;

            payroll.AddEmployee(expectedName,expectedSalary);
            var actual = payroll.GetEmployees()[0];

            Assert.AreEqual(actual.Name, expectedName);
            Assert.AreEqual(actual.Salary, expectedSalary);

        }

    }
}
