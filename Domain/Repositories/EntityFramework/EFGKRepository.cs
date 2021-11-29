using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFGKRepository : IGKRepository
    {
        private readonly AppDbContext context;
        public EFGKRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<GKEntity> GetGKs()
        {
            return context.GK;
        }

        public GKEntity GetGKById(int id)
        {
            return context.GK.FirstOrDefault(x => x.ID == id);
        }

        public GKEntity GetGKByName(string name)
        {
            return context.GK.FirstOrDefault(x => x.Name == name);
        }

        public GKEntity GetGKByRegion(string region)
        {
            return context.GK.FirstOrDefault(x => x.Region == region);
        }

        public GKEntity GetGKByDistrict(string district)
        {
            return context.GK.FirstOrDefault(x => x.District == district);
        }

        public GKEntity GetGKByArea(string area)
        {
            return context.GK.FirstOrDefault(x => x.Area == area);
        }

        public GKEntity GetGKByStreet(string street)
        {
            return context.GK.FirstOrDefault(x => x.Street == street);
        }

        public GKEntity GetGKByNum(int num)
        {
            return context.GK.FirstOrDefault(x => x.Num == num);
        }

        public GKEntity GetGKByID_Builder(int id_builder)
        {
            return context.GK.FirstOrDefault(x => x.ID_Builder == id_builder);
        }

        public void SaveGKEntity(GKEntity entity)
        {
            if (entity.ID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteGKEntity(int id)
        {
            context.GK.Remove(new GKEntity() { ID = id });
            context.SaveChanges();
        }
    }
}
