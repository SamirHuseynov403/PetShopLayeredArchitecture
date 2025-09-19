using AutoMapper;
using PetShop.BLL.DTOs.Bio;
using PetShop.BLL.Services;

namespace PetShop.BLL.Manager
{
    public class FooterManager
    {
        private readonly ISocialService _socialService;
        private readonly IBioService _bioService;
        private readonly IMapper _mapper;

        public FooterManager(ISocialService socialService, IBioService bioService, IMapper mapper)
        {
            _socialService = socialService;
            _bioService = bioService;
            _mapper = mapper;
        }

        public async Task<BioDto> GetFooter()
        {
            var socials = await _socialService.GetAllAsync();
            var bio = await _bioService.GetAllAsync();

            var bioDto = _mapper.Map<BioDto>(bio.FirstOrDefault() ?? new BioDto());
            bioDto.Socials = socials.ToList();

            return bioDto;
            ;
        }
    }
}
