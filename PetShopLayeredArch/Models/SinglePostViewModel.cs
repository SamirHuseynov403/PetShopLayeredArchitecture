using PetShop.BLL.DTOs.BlogPost;

namespace PetShop.MVC.Models
{
    public class SinglePostViewModel
    {
        public List<BlogPostDto> BlogPosts { get; set; } = new List<BlogPostDto>();
        public BlogPostDto? BlogPost { get; set; }
    }
}
