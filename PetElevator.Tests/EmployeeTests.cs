using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PetElevator.HR;

namespace PetElevator.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void FullNameReturnsCorrectFormat()
        {
            Employee employee = new Employee("Test", "Testerson");

            string fullName = employee.FullName;

            Assert.AreEqual("Testerson, Test", fullName);
        }

        [TestMethod]
        public void RaiseSalaryTest_Positive()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(5); //raise 5%

            Assert.IsTrue(employee.Salary == 100 * 1.05);
        }

        [TestMethod]
        public void RaiseSalaryTest_Negative()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(-10); //"raise" by negative 10%

            Assert.AreEqual(100, employee.Salary); //salary should remain same
        }


        [DataTestMethod]
        [DataRow(new double[] { 25.00, 15.00, 10.25 }, new string[] { "Walking", "vac2", "vac3" }, 37.75)]
        [DataRow(new double[] { 12.00, 12.00, 12.00 }, new string[] { "vac", "vac1", "vac2" }, 36.00)]
        [DataRow(new double[] { 12.00, 12.00, 12.00 }, new string[] { "Walking", "Walking", "Walking" }, 18)]

        // [DataRow(new double[] { 10.00, 59.00, 11.35 }, 80.35)]


        public void GetBalanceDueEmployee_Test(double[] chargesArray, string[] serviceArray, double expectedBalance)
        {
            //arrange
            Employee employeeCustomer = new Employee("Aklile", "K");
            Dictionary<string, double> dictionaryInvoices = new Dictionary<string, double>();

            for (int i = 0; i < chargesArray.Length; i++)
            {
                dictionaryInvoices.Add(serviceArray[i], chargesArray[i]);
            }
            //act
            double actualBlance = employeeCustomer.GetBalanceDue(dictionaryInvoices);

            //assert
            Assert.AreEqual(expectedBalance, actualBlance);

        }
    }
}