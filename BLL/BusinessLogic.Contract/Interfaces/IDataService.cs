using System.Collections.Generic;
using System.Threading.Tasks;
using BL = BusinessLogic.Contract.Models;
using DA = DataAccess.Contract.Models;

namespace BusinessLogic.Contract.Interfaces
{
    public interface IDataService : IBusinessLogicService<BL.Data, DA.Data>
    {
    }
}
