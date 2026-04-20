using AutoMapper;
using SampleApplication.BusinessLayer.Dto;
using SampleApplication.Domain.Entities;

namespace SampleApplication.WebApi.Mapping
{
    public class PersonUpdateDtoProfile : Profile
    {
        public PersonUpdateDtoProfile()
        {
            CreateMap<PersonUpdateDto, Person>();
        }
    }
}
