using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int CustomerId)
        {
            Customer customer = new Customer(CustomerId);
            if(CustomerId==1)
            {
                customer.FirstName = "Anidh";
                customer.LastName = "Singh";
                customer.EmailAddress = "anidh.singh@gmail.com";
                customer.AddressList = addressRepository.RetrieveByCustomerId(CustomerId).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
