using EmployeePayroll;
using NUnit.Framework;

namespace EmployeePayrollTest
{
    public class Tests
    {
        Employee empTestObj;
        [SetUp]
        public void Setup()
        {
            empTestObj = new Employee();
        }
        //UC1 Check Connectivity
        [Test]
        public void WhenValidConnectionString_CheckConnetion_ShouldReturn_True()
        {
            bool expected = true;
            bool result = empTestObj.CheckConnection();
            Assert.AreEqual(expected, result);
        }
    }
}