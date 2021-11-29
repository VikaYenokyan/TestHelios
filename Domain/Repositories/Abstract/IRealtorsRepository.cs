using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IRealtorsRepository
    {
        IQueryable<RealtorEntity> GetRealtors();
        RealtorEntity GetRealtorById(int id);
        RealtorEntity GetRealtorByName(string name);
        RealtorEntity GetRealtorByWork(int work);
        RealtorEntity GetRealtorByContact(int contact);
        void SaveRealtorEntity(RealtorEntity entity);
        void DeleteRealtorEntity(int id);

    }
}
