using AutoMapper;
using DataAccess.Contract.Interfaces;
using DA = DataAccess.Contract.Models;
using BL = BusinessLogic.Contract.Models;
using BLI = BusinessLogic.Contract.Interfaces;

namespace BusinessLogic.Services
{
    public class BodyService : BusinessLogicService<BL.Body, DA.Body>, BLI.IBodyService
    {
        protected IBodyRepository _repository;
        private IMapper _mapper;

        public BodyService(IBodyRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

    }
}
