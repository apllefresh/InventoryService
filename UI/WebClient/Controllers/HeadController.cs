using Microsoft.AspNetCore.Mvc;
using D = DataAccess.Contract.Models;
using B = BusinessLogic.Contract.Models;
using BI = BusinessLogic.Contract.Interfaces;

namespace WebClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeadController : GenericController<B.Head, D.Head>
    {
        private BI.IHeadService _headService;

        public HeadController(BI.IHeadService headService) : base(headService)
        {
            _headService = headService;
        }
    }
}