using AutoMapper;
using DataAccess.Contract.Interfaces;
using DA = DataAccess.Contract.Models;
using BL = BusinessLogic.Contract.Models;
using BLI = BusinessLogic.Contract.Interfaces;

namespace BusinessLogic.Services
{
    public class ResultService : BusinessLogicService<BL.Result, DA.Result>, BLI.IResultService
    {
        protected IResultRepository _repository;
        private IMapper _mapper;

        public ResultService(IResultRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
