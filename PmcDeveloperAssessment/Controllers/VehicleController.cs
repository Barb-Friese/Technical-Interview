using Microsoft.AspNetCore.Mvc;
using PmcDeveloperAssessment.Components;
using PmcDeveloperAssessment.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PmcDeveloperAssessment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly ICustomerVehicleComponent _customerVehicleComponent;

        public VehicleController(ICustomerVehicleComponent customerVehicleComponent)
        {
            _customerVehicleComponent = customerVehicleComponent;
        }

        [HttpGet("customerVehicles")]
        public async Task<IEnumerable<CustomerVehicleDto>> GetCustomerVehicles()
        {
            return await _customerVehicleComponent.GetCustomerVehiclesAsync();
        }
    }
}
