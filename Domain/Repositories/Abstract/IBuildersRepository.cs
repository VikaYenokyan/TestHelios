using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IBuildersRepository
    {
        IQueryable<BuilderEntity> GetBuilders();
        BuilderEntity GetBuilderById(int id);
        BuilderEntity GetBuilderByName(string name);
        BuilderEntity GetBuilderByYear(DateTime year);
        BuilderEntity GetBuilderByRented(int rented);
        BuilderEntity GetBuilderByBuild(int build);
        void SaveBuilderEntity(BuilderEntity entity);
        void DeleteBuilderEntity(int id);
    }
}
