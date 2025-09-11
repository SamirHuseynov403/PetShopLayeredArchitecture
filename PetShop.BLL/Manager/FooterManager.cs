using PetShop.BLL.DTOs.Bio;
using PetShop.BLL.Services;

namespace PetShop.BLL.Manager
{
    public class FooterManager 
    {
        private readonly ISocialService _socialService;
        private readonly IBioService _bioService;

        public FooterManager(ISocialService socialService, IBioService bioService)
        {
            _socialService = socialService;
            _bioService = bioService;
        }

        public async Task<BioDto> GetFooter()
        {
            var socials = await _socialService.GetAllAsync();
            var bio = await _bioService.GetAllAsync();


            var bioDto = new BioDto
            {
                Logo = bio.FirstOrDefault()?.Logo,
                Mail = bio.FirstOrDefault()?.Mail,
                Mobil = bio.FirstOrDefault()?.Mobil,
                Socials = socials.ToList()
            };

            return bioDto;
;
        }
    }
}
