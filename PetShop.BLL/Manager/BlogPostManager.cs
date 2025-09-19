using AutoMapper;
using PetShop.BLL.DTOs.BlogPost;
using PetShop.BLL.Services;
using PetShop.DAL.Entities;
using PetShop.DAL.Repositories.Interfaces;

namespace PetShop.BLL.Manager
{
    public class BlogPostManager : CrudManager<BlogPost, BlogPostDto, CreateBlogPostDto, UpdateBlogPostDto>, IBlogPostService
    {
        public BlogPostManager(IRepository<BlogPost> respository, IMapper mapper) : base(respository, mapper)
        {
        }
    }
}
