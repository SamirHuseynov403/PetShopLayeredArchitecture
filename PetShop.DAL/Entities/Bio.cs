
namespace PetShop.DAL.Entities
{
    public class Bio : BaseEntity
    {
        public string? Logo { get; set; }
        public string? Mail { get; set; }
        public string? Mobil { get; set; }
        public List<Social> Socials { get; set; } = new List<Social>();
    }
}
