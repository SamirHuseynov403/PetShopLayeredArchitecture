using PetShop.BLL.DTOs.Social;

namespace PetShop.BLL.DTOs.Bio
{
    public class BioDto
    {
        public string? Logo { get; set; }
        public string? Mail { get; set; }
        public string? Mobil { get; set; }
        public List<SocialDto> Socials { get; set; } = new List<SocialDto>();
    }
}
