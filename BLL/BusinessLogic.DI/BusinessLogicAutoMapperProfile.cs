using AutoMapper;
using BLBaseModels = BusinessLogic.Models;
using BLContractModels = BusinessLogic.Contract.Models;
using BLContractInterfaces = BusinessLogic.Contract.Interfaces;
using DAContractModels = DataAccess.Contract.Models;

namespace BusinessLogic.DI
{
    public class BusinessLogicAutoMapperProfile : Profile
    {
        public BusinessLogicAutoMapperProfile()
        {
            CreateMap<DAContractModels.Body, BLContractModels.Body>()
                .ReverseMap();
            CreateMap<DAContractModels.Data, BLContractModels.Data>()
                .ReverseMap();
            CreateMap<DAContractModels.Head, BLContractModels.Head>()
                .ReverseMap();
            CreateMap<DAContractModels.Result, BLContractModels.Result>()
                .ReverseMap();
            CreateMap<DAContractModels.Warehouse, BLContractModels.Warehouse>()
                .ReverseMap();
            
            CreateMap<BLBaseModels.Body, BLContractModels.Body>()
                .ReverseMap();
            CreateMap<BLBaseModels.Data, BLContractModels.Data>()
                .ReverseMap();
            CreateMap<BLBaseModels.Head, BLContractModels.Head>()
                .ReverseMap();
            CreateMap<BLBaseModels.Result, BLContractModels.Result>()
                .ReverseMap();
            CreateMap<BLBaseModels.Warehouse, BLContractModels.Warehouse>()
                .ReverseMap();

            CreateMap<BLBaseModels.Body, DAContractModels.Body>()
                .ReverseMap();
            CreateMap<BLBaseModels.Data, DAContractModels.Data>()
                .ReverseMap();
            CreateMap<BLBaseModels.Head, DAContractModels.Head>()
                .ReverseMap();
            CreateMap<BLBaseModels.Result, DAContractModels.Result>()
                .ReverseMap();
            CreateMap<BLBaseModels.Warehouse, DAContractModels.Warehouse>()
                .ReverseMap();

        }
    }
}
