using DataAccess.Contract.Models;
using DataAccess.Contract.Interfaces;
using DataAccess.EF;
using AutoMapper;

namespace DataAccess.Repositories
{
    public class InventoryHeadRepository : DataAccessRepository<InventoryHead>, IInventoryHeadRepository
    {
        private DataAccessContext _context;
        private IMapper _mapper;
        public InventoryHeadRepository(DataAccessContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
