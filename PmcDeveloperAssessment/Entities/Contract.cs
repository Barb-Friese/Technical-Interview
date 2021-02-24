using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PmcDeveloperAssessment.Entities
{
    public partial class Contract
    {
        public Guid ContractId { get; set; }
        public int InternalId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateCancelled { get; set; }
        public Guid CustomerVehicleId { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerVehicle CustomerVehicle { get; set; }
    }
}
