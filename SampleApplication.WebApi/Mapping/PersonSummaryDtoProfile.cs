using AutoMapper;
using SampleApplication.BusinessLayer.Dto;
using SampleApplication.Domain.Entities;

namespace SampleApplication.WebApi.Mapping
{
    public class PersonSummaryDtoProfile : Profile
    {
        public PersonSummaryDtoProfile()
        {
            CreateMap<Person, PersonSummaryDto>();
        }
    }
}
