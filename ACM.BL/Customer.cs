using Acme.Common;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer :EntityBase,ILoggable
    {
        public Customer() : this(0)   //Constructor chaining
        {
            
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public string Log()
        {
            return $"{CustomerId}: {FullName} Email:{EmailAddress} Status: {EntityState.ToString()}";
}

        public override string ToString() => FirstName;
        public int CustomerType { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        //public Address HomeAddress { get; set; }
        //public Address WorkAddress { get; set; }
        //OR
        public List<Address> AddressList { get; set; }  //This property sets a HAS-A Relationship
        //We have to inilaize a list becoz for list, the default value is null. If a code try to access the List,the code willthrow NULLPointerException

        public string FirstName { get; set; }

        public static int InstanceCount { get; set; }

        public string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                string fullname = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;

            }
        }

        public object EntityState { get; private set; }

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

       
    }
}
