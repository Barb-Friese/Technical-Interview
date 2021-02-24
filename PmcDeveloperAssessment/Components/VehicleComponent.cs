using Microsoft.EntityFrameworkCore;
using PmcDeveloperAssessment.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PmcDeveloperAssessment.Components
{
    public class VehicleComponent : IVehicleComponent
    {
        private readonly DBInterviewContext _context;
        private readonly ICustomerVehicleComponent _customerVehicleComponent;

        public VehicleComponent(DBInterviewContext context, ICustomerVehicleComponent customerVehicleComponent)
        {
            _context = context;
            _customerVehicleComponent = customerVehicleComponent;
        }

        public async Task<Vehicle> GetVehicleAsync(Guid vehicleId)
        {
            return await _context.Vehicle
                .Where(vehicle => vehicle.VehicleId == vehicleId)
                .FirstOrDefaultAsync();
        }
    }

    public interface IVehicleComponent
    {
        Task<Vehicle> GetVehicleAsync(Guid vehicleId);
    }
}
