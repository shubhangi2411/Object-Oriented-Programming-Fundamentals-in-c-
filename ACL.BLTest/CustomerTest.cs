using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACL.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer cust = new Customer
            {
                FirstName = "Shubhangi",
            LastName = "Chaturvedi"
           };

            string expected = "Chaturvedi Shubhangi";
            //Act
            string actual = cust.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
