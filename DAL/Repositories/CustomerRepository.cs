using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Context;
using DAL.Repositories.Interfaces;
using Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class CustomerRepository : ApplicationContext, ICustomerRepository
    {
        private readonly ApplicationContext _dbContext;

        public CustomerRepository(ApplicationContext dbContext) : base(new DbContextOptions<ApplicationContext>())
        {
            _dbContext = dbContext;
        }

        public Customer GetCustomerByTerm(string term)
        {
            return _dbContext.Customers.FirstOrDefault(x => x.Email.ToLower() == term.ToLower());
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }
    }
}
