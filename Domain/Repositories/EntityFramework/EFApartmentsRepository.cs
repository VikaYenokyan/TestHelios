using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFApartmentsRepository : IApartmentsRepository
    {
        private readonly AppDbContext context;
        public EFApartmentsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ApartmentEntity> GetApartments()
        {
            return context.Apartments;
        }

        public ApartmentEntity GetApartmentById(int id)
        {
            return context.Apartments.FirstOrDefault(x => x.ID == id);
        }

        public ApartmentEntity GetApartmentByRegion(string region)
        {
            return context.Apartments.FirstOrDefault(x => x.Region == region);
        }

        public ApartmentEntity GetApartmentByDistrict(string district)
        {
            return context.Apartments.FirstOrDefault(x => x.District == district);
        }

        public ApartmentEntity GetApartmentByArea(string area)
        {
            return context.Apartments.FirstOrDefault(x => x.Area == area);
        }

        public ApartmentEntity GetApartmentByStreet(string street)
        {
            return context.Apartments.FirstOrDefault(x => x.Street == street);
        }

        public ApartmentEntity GetApartmentByNum(int num)
        {
            return context.Apartments.FirstOrDefault(x => x.Num == num);
        }

        public ApartmentEntity GetApartmentBySquare(int square)
        {
            return context.Apartments.FirstOrDefault(x => x.Square == square);
        }

        public ApartmentEntity GetApartmentByRooms(int rooms)
        {
            return context.Apartments.FirstOrDefault(x => x.Rooms == rooms);
        }

        public ApartmentEntity GetApartmentByFloor(int floor)
        {
            return context.Apartments.FirstOrDefault(x => x.Floor == floor);
        }

        public ApartmentEntity GetApartmentByPrice(int price)
        {
            return context.Apartments.FirstOrDefault(x => x.Price == price);
        }

        public ApartmentEntity GetApartmentByType_price(string type_price)
        {
            return context.Apartments.FirstOrDefault(x => x.Type_price == type_price);
        }

        public ApartmentEntity GetApartmentByType_apart(string type_apart)
        {
            return context.Apartments.FirstOrDefault(x => x.Type_apart == type_apart);
        }

        public ApartmentEntity GetApartmentByID_Realtor(int id_realtor)
        {
            return context.Apartments.FirstOrDefault(x => x.ID_Realtor == id_realtor);
        }

        public ApartmentEntity GetApartmentByID_GK(int id_gk)
        {
            return context.Apartments.FirstOrDefault(x => x.ID_GK == id_gk);
        }

        public void SaveApartmentEntity(ApartmentEntity entity)
        {
            if (entity.ID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteApartmentEntity(int id)
        {
            context.Apartments.Remove(new ApartmentEntity() { ID = id });
            context.SaveChanges();
        }
    }
}
