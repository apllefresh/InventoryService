using Microsoft.AspNetCore.Mvc;
using D = DataAccess.Contract.Models;
using B = BusinessLogic.Contract.Models;
using BI = BusinessLogic.Contract.Interfaces;

namespace WebClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : GenericController<B.Data, D.Data>
    {
        private BI.IDataService _dataService;

        public DataController(BI.IDataService dataService) : base(dataService)
        {
            _dataService = dataService;
        }
    }
}