using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PmcDeveloperAssessment.Entities
{
    public partial class CustomerVehicle
    {
        public CustomerVehicle()
        {
            Contract = new HashSet<Contract>();
        }

        public Guid CustomerVehicleId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? VehicleId { get; set; }
        public string VehicleYear { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public string Style { get; set; }
        public int? Mileage { get; set; }
        public int? Year { get; set; }
        public string Vinnumber { get; set; }
        public bool? Turbo { get; set; }
        public bool? SuperCharger { get; set; }
        public bool? Hybrid { get; set; }
        public bool? Awd { get; set; }
        public bool? Aws { get; set; }
        public bool? Dually { get; set; }
        public bool? FourByFour { get; set; }
        public bool? OneTon { get; set; }
        public bool? V10 { get; set; }
        public bool? Diesel { get; set; }
        public string PolicyClass { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Modifications { get; set; }
        public bool? PreExistingConditions { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
    }
}
