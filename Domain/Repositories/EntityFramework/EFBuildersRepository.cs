using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFBuildersRepository : IBuildersRepository
    {
        private readonly AppDbContext context;
        public EFBuildersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<BuilderEntity> GetBuilders()
        {
            return context.Builder;
        }

        public BuilderEntity GetBuilderById(int id)
        {
            return context.Builder.FirstOrDefault(x => x.ID == id);
        }

        public BuilderEntity GetBuilderByName(string name)
        {
            return context.Builder.FirstOrDefault(x => x.Name == name);
        }

        public BuilderEntity GetBuilderByYear(DateTime year)
        {
            return context.Builder.FirstOrDefault(x => x.Year == year);
        }

        public BuilderEntity GetBuilderByRented(int rented)
        {
            return context.Builder.FirstOrDefault(x => x.Rented == rented);
        }

        public BuilderEntity GetBuilderByBuild(int build)
        {
            return context.Builder.FirstOrDefault(x => x.Build == build);
        }

        public void SaveBuilderEntity(BuilderEntity entity)
        {
            if (entity.ID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteBuilderEntity(int id)
        {
            context.Builder.Remove(new BuilderEntity() { ID = id });
            context.SaveChanges();
        }
    }
}
