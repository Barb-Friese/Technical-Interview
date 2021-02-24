using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PmcDeveloperAssessment.Entities
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            CustomerVehicle = new HashSet<CustomerVehicle>();
        }

        public Guid VehicleId { get; set; }
        public string VinPattern { get; set; }
        public string VehicleYear { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public string Style { get; set; }
        public string VehicleType { get; set; }
        public string BodyType { get; set; }
        public string BodySubType { get; set; }
        public string Doors { get; set; }
        public string Msrp { get; set; }
        public string Plant { get; set; }
        public string RestraintType { get; set; }
        public string Gvwrange { get; set; }
        public string Length { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string WheelBase { get; set; }
        public string CurbWeight { get; set; }
        public string GrossVehicleWeightRating { get; set; }
        public string TmpwheelDiamiter { get; set; }
        public string Tmptake1Gallon { get; set; }
        public string MaxPayload { get; set; }
        public string Tonnage { get; set; }
        public string WidthNoMirros { get; set; }
        public string LengthNoBumpers { get; set; }
        public string DriveType { get; set; }
        public string FuelType { get; set; }
        public string DefEngineBlock { get; set; }
        public string DefEngineCylinders { get; set; }
        public string DefEngineSize { get; set; }
        public string EngineSizeOum { get; set; }
        public string DefEngineAspriation { get; set; }
        public string DefTransType { get; set; }
        public string PolicyClass { get; set; }
        public string DefTransSpeed { get; set; }
        public DateTime? DateCreated { get; set; }
        public string AmbassadorClass { get; set; }
        public string DiamondClass { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<CustomerVehicle> CustomerVehicle { get; set; }
    }
}
