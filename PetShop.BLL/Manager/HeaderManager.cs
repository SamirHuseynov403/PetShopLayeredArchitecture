using AutoMapper;
using PetShop.BLL.DTOs.Bio;
using PetShop.BLL.Services;
using PetShop.DAL.Entities;

namespace PetShop.BLL.Manager
{
    public class HeaderManager 
    {
        private readonly ISocialService _socialService;
        private readonly IBioService _bioService;
        private readonly IMapper _mapper;

        public HeaderManager(ISocialService socialService, IBioService bioService, IMapper mapper)
        {
            _socialService = socialService;
            _bioService = bioService;
            _mapper = mapper;
        }

        public async Task<BioDto> GetHeaderAsync()
        {
            var socials = await _socialService.GetAllAsync();
            var bio = await _bioService.GetAllAsync();

            var headerDto = _mapper.Map<BioDto>(bio.FirstOrDefault()?? new BioDto());
            
            headerDto.Socials = socials.ToList();

            return headerDto;
        }
    }
}
