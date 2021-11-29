using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IApartmentsRepository
    {
        IQueryable<ApartmentEntity> GetApartments();
        ApartmentEntity GetApartmentById(int id);
        ApartmentEntity GetApartmentByRegion(string region);
        ApartmentEntity GetApartmentByDistrict(string district);
        ApartmentEntity GetApartmentByArea(string area);
        ApartmentEntity GetApartmentByStreet(string street);
        ApartmentEntity GetApartmentByNum(int num);
        ApartmentEntity GetApartmentBySquare(int square);
        ApartmentEntity GetApartmentByRooms(int rooms);
        ApartmentEntity GetApartmentByFloor(int floor);
        ApartmentEntity GetApartmentByPrice(int price);
        ApartmentEntity GetApartmentByType_price(string type_price);
        ApartmentEntity GetApartmentByType_apart(string type_apart);
        ApartmentEntity GetApartmentByID_Realtor(int id_realtor);
        ApartmentEntity GetApartmentByID_GK(int id_gk);
        void SaveApartmentEntity(ApartmentEntity entity);
        void DeleteApartmentEntity(int id);
    }
}
