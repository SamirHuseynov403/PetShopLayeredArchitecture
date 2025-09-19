using PetShop.DAL.Data;
using PetShop.DAL.Entities;
using PetShop.DAL.Repositories.Interfaces;


namespace PetShop.DAL.Repositories.Implementations
{
    public class BlogPostRepository : Repository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(AppDbContext context) : base(context)
        {
        }
    }
}
