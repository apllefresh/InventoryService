using Microsoft.AspNetCore.Mvc;
using D = DataAccess.Contract.Models;
using B = BusinessLogic.Contract.Models;
using BI = BusinessLogic.Contract.Interfaces;

namespace WebClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : GenericController<B.Warehouse, D.Warehouse>
    {
        private BI.IWarehouseService _warehouseService;

        public WarehouseController(BI.IWarehouseService warehouseService) : base(warehouseService)
        {
            _warehouseService = warehouseService;
        }
    }
}