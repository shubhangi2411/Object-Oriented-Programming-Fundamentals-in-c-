using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACL.BLTest
{
    [TestClass]
    public class ProductRepositoryTest    {
        [TestMethod]
        public void SaveMethodTesting()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Chocolate",
                Description = "Sweet",
                CurrentPrice = null,    
                HasChanges=true
            };

            var actual = productRepository.Save(updatedProduct);

            Assert.AreEqual(false, actual);
                }
    }
}
