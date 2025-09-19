using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetShop.DAL.Entities;

namespace PetShop.DAL.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Entities.Bio> Bios { get; set; }
        public DbSet<Entities.Social> Socials { get; set; }
        public DbSet<Entities.BlogPost> BlogPosts { get; set; }


    }
}
