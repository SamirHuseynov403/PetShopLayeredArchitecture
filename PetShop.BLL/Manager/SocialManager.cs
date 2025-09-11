using AutoMapper;
using PetShop.BLL.DTOs.Social;
using PetShop.BLL.Services;
using PetShop.DAL.Entities;
using PetShop.DAL.Repositories.Interfaces;

namespace PetShop.BLL.Manager
{
    public class SocialManager : CrudManager<Social, SocialDto, CreateSocialDto, UpdateSocialDto>, ISocialService
    {
        public SocialManager(IRepository<Social> respository, IMapper mapper) : base(respository, mapper)
        {
        }
        
    }
}
