
namespace PetShop.DAL.Entities
{
    public class BlogPost : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string Content { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public string? Author { get; set; } 
        public string? ImageUrl { get; set; }
    }
}
