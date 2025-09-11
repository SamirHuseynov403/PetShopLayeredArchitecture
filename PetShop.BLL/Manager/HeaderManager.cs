using PetShop.BLL.DTOs.Bio;
using PetShop.BLL.Services;

namespace PetShop.BLL.Manager
{
    public class HeaderManager 
    {
        private readonly ISocialService _socialService;
        private readonly IBioService _bioService;

        public HeaderManager(ISocialService socialService, IBioService bioService)
        {
            _socialService = socialService;
            _bioService = bioService;
        }

        public async Task<BioDto> GetHeaderAsync()
        {
            var socials = await _socialService.GetAllAsync();
            var bio = await _bioService.GetAllAsync();


            var headerDto = new BioDto
            {
                Logo = bio.FirstOrDefault()?.Logo,
                Mail = bio.FirstOrDefault()?.Mail,
                Mobil = bio.FirstOrDefault()?.Mobil,
                Socials = socials.ToList()
            };

            return headerDto;
        }
    }
}
