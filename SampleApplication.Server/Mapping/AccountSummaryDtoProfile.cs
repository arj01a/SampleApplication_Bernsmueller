using AutoMapper;
using SampleApplication.BusinessLayer.Dto;
using SampleApplication.Domain.Entities;

namespace SampleApplication.WebApi.Mapping
{
    public class AccountSummaryDtoProfile : Profile
    {
        public AccountSummaryDtoProfile() 
        {
            CreateMap<Account, AccountSummaryDto>();
        }
    }
}
