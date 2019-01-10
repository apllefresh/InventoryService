using AutoMapper;
using BaseModels = DataAccess.Models;
using ContractModels = DataAccess.Contract.Models;

namespace DAL.DI
{
    public class DataAccessAutoMapperProfile : Profile
    {
        public DataAccessAutoMapperProfile()
        {
            CreateMap<BaseModels.Body, ContractModels.Body>()
                    .ReverseMap();
            CreateMap<BaseModels.Data, ContractModels.Data>()
                    .ReverseMap();
            CreateMap<BaseModels.Head, ContractModels.Head>()
                    .ReverseMap();
            CreateMap<BaseModels.Result, ContractModels.Result>()
                    .ReverseMap();
            CreateMap<BaseModels.Warehouse, ContractModels.Warehouse>()
                    .ReverseMap();
        }
    }
}
