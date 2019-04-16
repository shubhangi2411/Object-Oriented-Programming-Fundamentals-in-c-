using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public  class ProductRepository
    {

        public Product Retrieve(int ProductId)
        {
            Product product = new Product(ProductId);
            if (ProductId == 2)
            {

          
            product.ProductName = "Chocolate";
            product.Description="Sweet";
            product.CurrentPrice = 45;
            }
            return product;

        }

        public bool Save(Product product)
        {
            var success = true;

            if(product.HasChanges)
            {
                if(product.ĪsValid)
                {
                    if(product.IsNew)
                    {
                        //call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success=false;
                }
               
            }
            return success;
        }
    }
}
