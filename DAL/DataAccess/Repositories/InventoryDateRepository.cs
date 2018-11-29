using DataAccess.Contract.Models;
using DataAccess.Contract.Interfaces;
using DataAccess.EF;
using AutoMapper;

namespace DataAccess.Repositories
{
    public class InventoryDateRepository : DataAccessRepository<InventoryDate>, IInventoryDateRepository
    {
        private DataAccessContext _context;
        private IMapper _mapper;
        public InventoryDateRepository(DataAccessContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
