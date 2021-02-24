using Microsoft.EntityFrameworkCore;
using PmcDeveloperAssessment.Dtos;
using PmcDeveloperAssessment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmcDeveloperAssessment.Components
{
    public class CustomerVehicleComponent : ICustomerVehicleComponent
    {
        private readonly DBInterviewContext _context;
        //private readonly IVehicleComponent _vehicleComponent;

        public CustomerVehicleComponent(DBInterviewContext context/*, IVehicleComponent vehicleComponent*/)
        {
            _context = context;
            //_vehicleComponent = vehicleComponent;
        }

        public async Task<IEnumerable<CustomerVehicleDto>> GetCustomerVehiclesAsync()
        {
            var customerVehicleDtos = new List<CustomerVehicleDto>();

            var customerVehicles = await _context.CustomerVehicle
                .Take(100)
                .ToListAsync();

            foreach (var customerVehicle in customerVehicles)
            {
                //var vehicle = await _vehicleComponent.GetVehicleAsync((Guid)customerVehicle.VehicleId);
                customerVehicleDtos.Add(new CustomerVehicleDto
                {
                    CustomerVehicleId = customerVehicle.CustomerVehicleId,
                    VehicleId = customerVehicle.VehicleId,
                    VehicleYear = customerVehicle.VehicleYear,
                    Make = customerVehicle.Make,
                    Model = customerVehicle.Model,
                    Trim = customerVehicle.Trim,
                    Style = customerVehicle.Style,

                    //VinPattern = vehicle.VinPattern,
                    //VehicleType = vehicle.VehicleType,
                    //BodyType = vehicle.BodyType,
                    //BodySubType = vehicle.BodySubType,
                    //Doors = vehicle.Doors,
                    //Msrp = vehicle.Msrp,
                    //Plant = vehicle.Plant
                });
            }

            return customerVehicleDtos;     
        }
    }

    public interface ICustomerVehicleComponent
    {
        Task<IEnumerable<CustomerVehicleDto>> GetCustomerVehiclesAsync();
    }
}
