using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACL.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void TestCustomerDetails()
        {

            var customerrepo = new CustomerRepository();

            var expected = new Customer(1)
            {

                FirstName = "Anidh",
                LastName = "Singh",
                EmailAddress = "anidh.cingh@gmail.com"
            };

            var actual = customerrepo.Retrieve(1);

            Assert.AreEqual(expected.FirstName, actual.FirstName);

        }
    }
}
