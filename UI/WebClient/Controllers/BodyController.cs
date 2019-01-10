using Microsoft.AspNetCore.Mvc;
using D = DataAccess.Contract.Models;
using B = BusinessLogic.Contract.Models;
using BI = BusinessLogic.Contract.Interfaces;

namespace WebClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyController : GenericController<B.Body, D.Body>
    {
        private BI.IBodyService _bodyService;

        public BodyController(BI.IBodyService bodyService) : base(bodyService)
        {
            _bodyService = bodyService;
        }
    }
}