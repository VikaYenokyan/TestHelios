using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IGKRepository
    {
        IQueryable<GKEntity> GetGKs();
        GKEntity GetGKById(int id);
        GKEntity GetGKByName(string name);
        GKEntity GetGKByRegion(string region);
        GKEntity GetGKByDistrict(string district);
        GKEntity GetGKByArea(string area);
        GKEntity GetGKByStreet(string street);
        GKEntity GetGKByNum(int num);
        GKEntity GetGKByID_Builder(int id_builder);
        void SaveGKEntity(GKEntity entity);
        void DeleteGKEntity(int id);
    }
}
