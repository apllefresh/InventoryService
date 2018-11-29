using AutoMapper;
using DataAccess.Contract.Interfaces;
using DataAccess.EF;
using DataAccess.Contract.Models;

namespace DataAccess.Repositories
{
    public class InventorySpaceRepository : DataAccessRepository<InventorySpace>, IInventorySpaceRepository
    {
        private DataAccessContext _context;
        private IMapper _mapper;

        public InventorySpaceRepository(DataAccessContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
