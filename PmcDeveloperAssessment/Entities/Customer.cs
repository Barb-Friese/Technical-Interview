using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PmcDeveloperAssessment.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Contract = new HashSet<Contract>();
            CustomerVehicle = new HashSet<CustomerVehicle>();
        }

        public Guid CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Guid AddressId { get; set; }
        public string EmailAddress { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouceLastName { get; set; }
        public string HomeOwner { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<CustomerVehicle> CustomerVehicle { get; set; }
    }
}
