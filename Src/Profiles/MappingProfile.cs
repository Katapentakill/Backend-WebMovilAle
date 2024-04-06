using AutoMapper;
using taller1WebMovil.Src.DTOs;
using taller1WebMovil.Src.Models;

namespace taller1WebMovil.Src.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterUserDTO, User>(); //Mapeo de RegisterUserDTO a User
            //CreateMap<ProductDTO, Product>(); //Mapeo de ProductDTO a Product
        }
    }
}