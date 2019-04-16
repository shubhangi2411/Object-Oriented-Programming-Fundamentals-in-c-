using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public  class Product : EntityBase , ILoggable
    {
        public Product()
        {

        }

        public Product(int productid)
        {
            ProductId = productid;
        }

        public int ProductId { get; private set; }
        public string _productName;
        public string ProductName
        {

            get
            {
               
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        public string Log()
        {
            return $"{ProductId}: {ProductName} Email:{Description} Status: {EntityState.ToString()}";
        public string  Description { get; set; }

        public decimal? CurrentPrice { get; set; }   // ? => denotes a nullable type like decimal or integer that allows the definition to be a value or a null 

        public override string ToString() => ProductName;   //Expression Body syntax for a method
        public override bool Validate()
        {
            var isValid = true;

            if (String.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice==null) isValid = false;

            return isValid;
        }

        
    }
}
