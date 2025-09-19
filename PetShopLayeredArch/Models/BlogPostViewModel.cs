using PetShop.BLL.DTOs.BlogPost;
using PetShop.DAL.Entities;

namespace PetShop.MVC.Models
{
    public class BlogPostViewModel
    {
        public List<BlogPostDto> BlogPosts { get; set; } = new List<BlogPostDto>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
