using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFRealtorRepository : IRealtorsRepository
    {
        private readonly AppDbContext context;
        public EFRealtorRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<RealtorEntity> GetRealtors()
        {
            return context.Realtor;
        }

        public RealtorEntity GetRealtorById(int id)
        {
            return context.Realtor.FirstOrDefault(x => x.ID == id);
        }

        public RealtorEntity GetRealtorByName(string name)
        {
            return context.Realtor.FirstOrDefault(x => x.Name == name);
        }

        public RealtorEntity GetRealtorByWork(int work)
        {
            return context.Realtor.FirstOrDefault(x => x.Work == work);
        }

        public RealtorEntity GetRealtorByContact(int contact)
        {
            return context.Realtor.FirstOrDefault(x => x.Contact == contact);
        }

        public void SaveRealtorEntity(RealtorEntity entity)
        {
            if (entity.ID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteRealtorEntity(int id)
        {
            context.Realtor.Remove(new RealtorEntity() { ID = id });
            context.SaveChanges();
        }
    }
}
