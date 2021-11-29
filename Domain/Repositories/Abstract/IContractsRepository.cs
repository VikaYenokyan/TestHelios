using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IContractsRepository
    {
        IQueryable<ContractEntity> GetContracts();
        ContractEntity GetContractById(int id);
        ContractEntity GetContractByDate_1(DateTime date_1);
        ContractEntity GetContractByDate_2(DateTime date_2);
        ContractEntity GetContractByID_Apartments(int id_apartments);
        ContractEntity GetContractByID_Customer(int id_customer);
        void SaveContractEntity(ContractEntity entity);
        void DeleteContractEntity(int id);
    }
}
