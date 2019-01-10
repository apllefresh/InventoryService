using Microsoft.AspNetCore.Mvc;
using D = DataAccess.Contract.Models;
using B = BusinessLogic.Contract.Models;
using BI = BusinessLogic.Contract.Interfaces;

namespace WebClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : GenericController<B.Result, D.Result>
    {
        private BI.IResultService _resultService;

        public ResultController(BI.IResultService resultService) : base(resultService)
        {
            _resultService = resultService;
        }
    }
}