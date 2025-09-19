using PetShop.BLL.DTOs.BlogPost;
using PetShop.DAL.Entities;

namespace PetShop.BLL.Services
{
    public interface IBlogPostService : ICrudService<BlogPost, BlogPostDto, CreateBlogPostDto, UpdateBlogPostDto>
    {

    }
}
