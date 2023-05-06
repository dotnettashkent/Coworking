using AutoMapper;
using Coworking.Domain.Entities;
using Coworking.Service.DTOs;

namespace Coworking.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //User

            CreateMap<User, UserCreationDto>().ReverseMap();
            CreateMap<User, UserResultDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();

            //Coworking

            CreateMap<Coworkingg, CoworkingCreationDto>().ReverseMap();
            CreateMap<Coworkingg, CoworkingUpdateDto>().ReverseMap();
            CreateMap<Coworkingg, CoworkingResultDto>().ReverseMap();
        }
    }
}
