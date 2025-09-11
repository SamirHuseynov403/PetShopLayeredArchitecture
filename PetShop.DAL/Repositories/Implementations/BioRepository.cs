using PetShop.DAL.Data;
using PetShop.DAL.Entities;
using PetShop.DAL.Repositories.Interfaces;


namespace PetShop.DAL.Repositories.Implementations
{
    public class BioRepository : Repository<Bio>, IBioRepository
    {
        public BioRepository(AppDbContext context) : base(context)
        {
        }
    }
}
