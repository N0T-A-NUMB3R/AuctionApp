using AutoMapper;
using Contracts;
using SearchService.Models;

namespace SearchService.RequestHelper
{
    public class MappingProfiles : Profile
    {
         public MappingProfiles()
        {
            CreateMap<Contracts.AuctionCreated, Item>();
        }
    }
}