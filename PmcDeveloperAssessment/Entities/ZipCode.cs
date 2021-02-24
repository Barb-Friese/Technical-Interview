using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PmcDeveloperAssessment.Entities
{
    public partial class ZipCode
    {
        public string State { get; set; }
        public string City { get; set; }
        public string Postal { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public Guid ZipCodeId { get; set; }
    }
}
