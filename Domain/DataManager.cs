using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IApartmentsRepository Apartments { get; set; }
        public IBuildersRepository Builder { get; set; }
        public IContractsRepository Contracts { get; set; }
        public ICustomersRepository Customer { get; set; }
        public IGKRepository GK { get; set; }
        public IRealtorsRepository Realtor { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IApartmentsRepository apartmentsRepository, IBuildersRepository buildersRepository,
            IContractsRepository contractsRepository, ICustomersRepository customersRepository,
            IGKRepository gkRepository, IRealtorsRepository realtorsRepository)
        {
            TextFields = textFieldsRepository;
            Apartments = apartmentsRepository;
            Builder = buildersRepository;
            Contracts = contractsRepository;
            Customer = customersRepository;
            GK = gkRepository;
            Realtor = realtorsRepository;
        }
    }
}
