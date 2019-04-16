using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int OrderId)
        {
            Order order = new Order(OrderId);
            if(OrderId==3)
            {
                order.OrderDate = DateTime.Now.ToLocalTime();
                
            }
            return order;

        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}
