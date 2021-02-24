using PmcDeveloperAssessment.Entities;
using System;

namespace PmcDeveloperAssessment.Dtos
{
    public class CustomerAddressDto
    {
        //Customer
        public Guid CustomerId { get; set; }
        public DateTime CustomerDateCreated { get; set; }
        public DateTime CustomerDateModified { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Guid AddressId { get; set; }
        public string EmailAddress { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouceLastName { get; set; }
        public string HomeOwner { get; set; }

        //Address
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime AddressDateCreated { get; set; }
        public DateTime AddressDateModified { get; set; }

        public CustomerAddressDto(Customer customer)
        {
            this.CustomerId = customer.CustomerId;
            this.CustomerDateCreated = customer.DateCreated;
            this.CustomerDateModified = customer.DateModified;
            this.FirstName = customer.FirstName;
            this.LastName = customer.LastName;
            this.Phone = customer.Phone;
            this.AddressId = customer.AddressId;
            this.EmailAddress = customer.EmailAddress;
            this.SpouseFirstName = customer.SpouseFirstName;
            this.SpouceLastName = customer.SpouceLastName;
            this.HomeOwner = customer.HomeOwner;

            this.Address1 = customer.Address.Address1;
            this.Address2 = customer.Address.Address2;
            this.City = customer.Address.City;
            this.State = customer.Address.State;
            this.Zip = customer.Address.Zip;
            this.AddressDateCreated = (DateTime)customer.Address.DateCreated;
            this.AddressDateModified = (DateTime)customer.Address.DateModified;
        }
    }
}
