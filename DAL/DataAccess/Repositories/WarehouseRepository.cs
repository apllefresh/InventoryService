using AutoMapper;
using DataAccess.Contract.Interfaces;
using DataAccess.EF;
using DataAccess.Contract.Models;

namespace DataAccess.Repositories
{
    public class WarehouseRepository : DataAccessRepository<Warehouse>, IWarehouseRepository
    {
        protected DataAccessContext _context;
        protected IMapper _mapper;

        public WarehouseRepository(DataAccessContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
