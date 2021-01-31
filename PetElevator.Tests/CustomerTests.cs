using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using PetElevator.HR;

namespace PetElevator.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CustomerBalanceDue()
        {
            Customer customer = new Customer("John", "Smith");

            double balanceDue = 0.5;
            Dictionary<string, double> services = new Dictionary<string, double>();
            services.Add("Walking", 0.5);


            Assert.AreEqual(balanceDue, customer.GetBalanceDue(services));
        }

        [TestMethod]
        public void EmployeeBalanceDue()
        {
            Employee employee = new Employee("Jane", "Doe");

            double balanceDue = 0.25;
            Dictionary<string, double> services = new Dictionary<string, double>();
            services.Add("Walking", 0.5);

            Assert.AreEqual(balanceDue, employee.GetBalanceDue(services));
        }
    }
}
