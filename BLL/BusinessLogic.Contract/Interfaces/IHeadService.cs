﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BL = BusinessLogic.Contract.Models;
using DA = DataAccess.Contract.Models;

namespace BusinessLogic.Contract.Interfaces
{
    public interface IHeadService : IBusinessLogicService<BL.Head, DA.Head>
    {
    }
}
