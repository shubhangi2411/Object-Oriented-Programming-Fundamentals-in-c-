using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringHandlerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertSpacesValidTest()
        {
            var source = "ShubhangiChaturvedi";
            var expected = "Shubhangi Chaturvedi";

            
            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }

        public void InsertSpacesWithAlreadySpacesValidTest()
        {
            var source = "Shubhangi Chaturvedi";
            var expected = "Shubhangi Chaturvedi";

           
            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }
    }
}
