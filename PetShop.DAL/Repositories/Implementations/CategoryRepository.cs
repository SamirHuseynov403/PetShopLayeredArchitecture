using PetShop.DAL.Data;
using PetShop.DAL.Entities;
using PetShop.DAL.Repositories.Interfaces;


namespace PetShop.DAL.Repositories.Implementations
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
