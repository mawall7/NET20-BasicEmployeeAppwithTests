using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicEmployeeAppwithTests;

namespace BasicEmployeeAppTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Get_ShouldReturn_SalaryLevelJunior()
        {
            const int salary = 10000;
            var employee = new Employee("Kalle", 10000);
            
            var actual = employee.Salarylevel;

            Assert.AreEqual(actual, SalaryLevel.junior);

        }
        [TestMethod]
        public void ShouldReturnEmployeeNameAndSalary()
        {
            var employee = new Employee("Nick", 20000);

            var actual = employee.ToString();

            Assert.AreEqual(actual,"Name:Nick,Salary:20000");
        }

        [TestMethod]
        public void ExpectedReturnTrue()
        {
            var emptystring = " ";

            Assert.IsTrue(string.IsNullOrWhiteSpace(emptystring));
        }




    }
}
