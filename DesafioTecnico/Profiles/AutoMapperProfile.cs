using AutoMapper;
using DesafioTecnico.Model.Dto;
using DesafioTecnico.Model.Entities;

namespace DesafioTecnico.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Resident, ResidentDto>();
            CreateMap<ResidentDto, Resident>();
        }
    }
}
