using AutoMapper;
using DataAccess.Contract.Interfaces;
using DataAccess.EF;
using DataAccess.Contract.Models;

namespace DataAccess.Repositories
{
    public class ResultRepository : DataAccessRepository<Result>, IResultRepository
    {
        protected DataAccessContext _context;
        protected IMapper _mapper;

        public ResultRepository(DataAccessContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
