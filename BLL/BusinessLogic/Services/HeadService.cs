using AutoMapper;
using DataAccess.Contract.Interfaces;
using DA = DataAccess.Contract.Models;
using BL = BusinessLogic.Contract.Models;
using BLI = BusinessLogic.Contract.Interfaces;

namespace BusinessLogic.Services
{
    public class HeadService : BusinessLogicService<BL.Head, DA.Head>, BLI.IHeadService
    {
        protected IHeadRepository _repository;
        private IMapper _mapper;

        public HeadService(IHeadRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
