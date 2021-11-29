using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Model
{
    public class Tuple
    {
        public IQueryable<CustomerEntity> Customerss { get; set; }
        public IQueryable<ContractEntity> Contractss { get; set; }
        public IQueryable<ApartmentEntity> Apartmentss { get; set; }
    }
}
