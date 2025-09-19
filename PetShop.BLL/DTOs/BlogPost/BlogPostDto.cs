using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BLL.DTOs.BlogPost
{
    public class BlogPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string Content { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public string? Author { get; set; }
        public string? ImageUrl { get; set; }
    }

    public class CreateBlogPostDto
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string Content { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public string? Author { get; set; }
        public string? ImageUrl { get; set; }
    }
    public class UpdateBlogPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string Content { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public string? Author { get; set; }
        public string? ImageUrl { get; set; }
    }

}
