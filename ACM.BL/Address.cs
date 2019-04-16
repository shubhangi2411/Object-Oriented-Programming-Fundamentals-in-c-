using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressid)
        {
            AddressId = addressid;
        }
        public int AddressId { get; set; }
        public string StreetLine1 { get; set; }

        public string StreetLine2 { get; set; }

        public string City { get; set; }

        public string  State { get; set; }

        public int PostalCode { get; set; }

        public string Country { get; set; }

        public string AddressType { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (PostalCode == 0) isValid = false;

            return isValid;
        }


    }
}
