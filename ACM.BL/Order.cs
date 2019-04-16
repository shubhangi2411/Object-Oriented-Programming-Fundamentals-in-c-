using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order :EntityBase, ILoggable
    {


        public Order():this(0)
        {

        }

        public Order(int orderid)
        {
            OrderId = orderid;
            OrderItems = new List<OrderItem>();
        }

        public override string ToString() => $"{OrderDate.Value.Date}({OrderId})";
        public DateTimeOffset? OrderDate { get; set; }    //The dateTimeOffset tracks the date time am=nd timezone offset.We can use this when date is set in diiferent timezones

        public int CustomerId { get; set; }

        public int ShippingAddressId { get; set; }

        public List<OrderItem> OrderItems { get; set; }
        public int OrderId { get; set; }

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public string Log()
        {
            return $"{OrderId}: {OrderDate} Status: {EntityState.ToString()}";
        }
    }
}
