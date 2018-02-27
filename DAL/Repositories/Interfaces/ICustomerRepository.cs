using System.Collections.Generic;
using Domain.Users;

namespace DAL.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomerByTerm(string term);
        IEnumerable<Customer> GetCustomers();
    }
}
