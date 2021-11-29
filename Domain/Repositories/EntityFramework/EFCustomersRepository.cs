using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFCustomersRepository : ICustomersRepository
    {
        private readonly AppDbContext context;
        public EFCustomersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<CustomerEntity> GetCustomers()
        {
            return context.Customer;
        }

        public CustomerEntity GetCustomerById(int id)
        {
            return context.Customer.FirstOrDefault(x => x.ID == id);
        }

        public CustomerEntity GetCustomerByName(string name)
        {
            return context.Customer.FirstOrDefault(x => x.Name == name);
        }

        public CustomerEntity GetCustomerByContact(int contact)
        {
            return context.Customer.FirstOrDefault(x => x.Contact == contact);
        }

        public void SaveCustomerEntity(CustomerEntity entity)
        {
            if (entity.ID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteCustomerEntity(int id)
        {
            context.Customer.Remove(new CustomerEntity() { ID = id });
            context.SaveChanges();
        }
    }
}
