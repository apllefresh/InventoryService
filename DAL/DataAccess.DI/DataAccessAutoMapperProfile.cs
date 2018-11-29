using AutoMapper;
using BaseModels = DataAccess.Models;
using ContractModels = DataAccess.Contract.Models;

namespace DAL.DI
{
    public class DataAccessAutoMapperProfile : Profile
    {
        public DataAccessAutoMapperProfile()
        {
            CreateMap<BaseModels.InventoryDate, ContractModels.InventoryDate>()
                    .ReverseMap();
            CreateMap<BaseModels.InventoryHead, ContractModels.InventoryHead>()
                    .ReverseMap();
            CreateMap<BaseModels.InventoryBody, ContractModels.InventoryBody>()
                    .ReverseMap();
            CreateMap<BaseModels.InventoryResult, ContractModels.InventoryResult>()
                    .ReverseMap();
            CreateMap<BaseModels.InventorySpace, ContractModels.InventorySpace>()
                    .ReverseMap();
            CreateMap<BaseModels.InventoryDateToSpaceMap, ContractModels.InventoryDateToSpaceMap>()
                    .ReverseMap();
        }
    }
}
