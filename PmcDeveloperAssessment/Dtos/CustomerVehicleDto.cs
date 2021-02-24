using System;

namespace PmcDeveloperAssessment.Dtos
{
    public class CustomerVehicleDto
    {
        //CustomerVehicle
        public Guid CustomerVehicleId { get; set; }
        public Guid? VehicleId { get; set; }
        public string VehicleYear { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public string Style { get; set; }

        //Vehicle
        public string VinPattern { get; set; }
        public string VehicleType { get; set; }
        public string BodyType { get; set; }
        public string BodySubType { get; set; }
        public string Doors { get; set; }
        public string Msrp { get; set; }
        public string Plant { get; set; }
    }
}
