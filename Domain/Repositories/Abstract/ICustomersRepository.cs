using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface ICustomersRepository
    {
        IQueryable<CustomerEntity> GetCustomers();
        CustomerEntity GetCustomerById(int id);
        CustomerEntity GetCustomerByName(string name);
        CustomerEntity GetCustomerByContact(int contact);
        void SaveCustomerEntity(CustomerEntity entity);
        void DeleteCustomerEntity(int id);
    }
}
