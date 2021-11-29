using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFContractsRepository : IContractsRepository
    {
        private readonly AppDbContext context;
        public EFContractsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ContractEntity> GetContracts()
        {
            return context.Contracts;
        }

        public ContractEntity GetContractById(int id)
        {
            return context.Contracts.FirstOrDefault(x => x.ID == id);
        }

        public ContractEntity GetContractByDate_1(DateTime date_1)
        {
            return context.Contracts.FirstOrDefault(x => x.Date_1 == date_1);
        }

        public ContractEntity GetContractByDate_2(DateTime date_2)
        {
            return context.Contracts.FirstOrDefault(x => x.Date_2 == date_2);
        }

        public ContractEntity GetContractByID_Apartments(int id_apartments)
        {
            return context.Contracts.FirstOrDefault(x => x.ID_Apartments == id_apartments);
        }

        public ContractEntity GetContractByID_Customer(int id_customer)
        {
            return context.Contracts.FirstOrDefault(x => x.ID_Customer == id_customer);
        }

        public void SaveContractEntity(ContractEntity entity)
        {
            if (entity.ID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteContractEntity(int id)
        {
            context.Contracts.Remove(new ContractEntity() { ID = id });
            context.SaveChanges();
        }
    }
}
