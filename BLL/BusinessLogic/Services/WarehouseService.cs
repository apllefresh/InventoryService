using AutoMapper;
using DataAccess.Contract.Interfaces;
using DA = DataAccess.Contract.Models;
using BL = BusinessLogic.Contract.Models;
using BLI = BusinessLogic.Contract.Interfaces;

namespace BusinessLogic.Services
{
    public class WarehouseService : BusinessLogicService<BL.Warehouse, DA.Warehouse>, BLI.IWarehouseService
    {
        protected IWarehouseRepository _repository;
        private IMapper _mapper;

        public WarehouseService(IWarehouseRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
