using PetShop.DAL.Data;
using PetShop.DAL.Entities;
using PetShop.DAL.Repositories.Interfaces;


namespace PetShop.DAL.Repositories.Implementations
{
    public class SocialRepository : Repository<Social>, ISocialRepository
    {
        public SocialRepository(AppDbContext context) : base(context)
        {
        }
    }
}
