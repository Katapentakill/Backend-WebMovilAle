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
            CreateMap<User, UserDTO>(); //Mapeo de User a UserDTO
            CreateMap<UserProfileEditDTO, User>();  //Mapeo de UserProfileEditDTO a User
            CreateMap<ProductDTO, Product>(); //Mapeo de ProductDTO a Product
            CreateMap<Product, ProductDTO>(); //Mapeo de Product a ProductDTO
            CreateMap<Purchase, PurchaseDTO>(); //Mapeo de Purchase a PurchaseDTO
            CreateMap<UpdateProductDTO, ProductDTO>(); //Mapeo de UpdateProductDTO a ProductDTO
            CreateMap<Product, UpdateProductDTO>(); //Mapeo de product a updateProductDTO
        }
    }
}