using Microsoft.AspNetCore.Mvc;
using PmcDeveloperAssessment.Components;
using PmcDeveloperAssessment.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PmcDeveloperAssessment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerComponent _customerComponent;

        public CustomerController(ICustomerComponent customerComponent)
        {
            _customerComponent = customerComponent;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerAddressDto>> Get()
        {
            return await _customerComponent.GetCustomerWithAddressAsync();
        }
    }
}
