using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemid)
        {
            OrderItemId = orderItemid;
        }

        public int OrderItemId { get; private set; }

        public int ProductId { get; set; }

        public decimal? PurchasePrice { get; set; }

        public int Quantity { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (Quantity <=0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }

        public bool Save()
        {
            return true;
        }

        public OrderItem Retrieve(int OrderItemId)
        {
            return new OrderItem();
        }
    }
}
