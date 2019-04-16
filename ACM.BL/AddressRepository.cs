using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public class AddressRepository
    {

        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if(addressId==1)
            {
                address.AddressType = "Home";
                address.StreetLine1 = "14/269 Kaveri Path";
                address.StreetLine2 = "Mansarover";
                address.City = "Jaipur";
                address.Country = "India";
                address.PostalCode = 302020;
                    }
            return address;
        }



        public bool Save(Address address)
        {
            return true;
        }
        
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {

            var addressList = new List<Address>(); 
                Address address = new Address(1);
            
            {
                address.AddressType = "Home";
                address.StreetLine1 = "14/269 Kaveri Path";
                address.StreetLine2 = "Mansarover";
                address.City = "Jaipur";
                address.Country = "India";
                address.PostalCode = 302020;
            }

            addressList.Add(address);

             address = new Address(2);

            {
                address.AddressType = "Work";
                address.StreetLine1 = "Igate Junctihotelon";
                address.StreetLine2 = "near Ginger ";
                address.City = "Bangalore";
                address.Country = "India";
                address.PostalCode = 560037;
            }

            addressList.Add(address);

            return addressList;
        }
    }
}
