using System.Collections.Generic;
using BLL.Dto.Customer;

namespace BLL.Services.Interfaces
{
    public interface ICustomerService
    {
        CustomerDto GetCustomerByTerm(string term);
        IEnumerable<CustomerDto> GetCustomers();
    }
}
