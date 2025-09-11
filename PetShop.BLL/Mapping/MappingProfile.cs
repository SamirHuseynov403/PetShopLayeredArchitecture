using AutoMapper;
using PetShop.BLL.DTOs.Bio;
using PetShop.BLL.DTOs.Social;
using PetShop.DAL.Entities;

namespace PetShop.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Bio,BioDto>().ReverseMap();
            CreateMap<Bio, CreateBioDto>().ReverseMap();
            CreateMap<Bio, UpdateBioDto>().ReverseMap();

            CreateMap<Social, SocialDto>().ReverseMap();
            CreateMap<Social, CreateSocialDto>().ReverseMap();
            CreateMap<Social, UpdateSocialDto>().ReverseMap();

        }
    }
}
