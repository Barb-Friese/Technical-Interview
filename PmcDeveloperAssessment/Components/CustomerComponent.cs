using Microsoft.EntityFrameworkCore;
using PmcDeveloperAssessment.Dtos;
using PmcDeveloperAssessment.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmcDeveloperAssessment.Components
{
    public class CustomerComponent
    {

    }

    public interface ICustomerComponent
    {
        Task<IEnumerable<CustomerAddressDto>> GetCustomerWithAddressAsync();
    }
}
