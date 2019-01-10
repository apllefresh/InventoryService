using AutoMapper;
using DataAccess.Contract.Interfaces;
using DA = DataAccess.Contract.Models;
using BL = BusinessLogic.Contract.Models;
using BLI = BusinessLogic.Contract.Interfaces;

namespace BusinessLogic.Services
{
    public class DataService : BusinessLogicService<BL.Data, DA.Data>, BLI.IDataService
    {
        protected IDataRepository _repository;
        private IMapper _mapper;

        public DataService(IDataRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
