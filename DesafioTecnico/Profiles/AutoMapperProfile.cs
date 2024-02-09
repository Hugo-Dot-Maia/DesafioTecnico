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

            CreateMap<Apartment, ApartmentDto>();
            CreateMap<ApartmentDto, Apartment>();

            CreateMap<Block, BlockDto>();
            CreateMap<BlockDto, Block>();

            CreateMap<Condominium, CondominiumDto>();
            CreateMap<CondominiumDto, Condominium>();
        }
    }
}
