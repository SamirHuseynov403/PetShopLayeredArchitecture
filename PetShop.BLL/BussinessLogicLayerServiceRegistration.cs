using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PetShop.BLL.Manager;
using PetShop.BLL.Mapping;
using PetShop.BLL.Services;
using PetShop.DAL.Data;
using PetShop.DAL.Repositories.Implementations;
using PetShop.DAL.Repositories.Interfaces;

namespace PetShop.BLL
{
    public static class DataAccessLayerServiceRegistration
    {
        public static IServiceCollection AddDAL(this IServiceCollection services, string? cs)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(cs));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<ISocialRepository, SocialRepository>();
            services.AddScoped<IBioRepository, BioRepository>();
            services.AddScoped<BlogPostRepository, BlogPostRepository>();

            return services;
        }
    }
    public static class BusinessLogicLayerServiceRegistration
    {
        public static IServiceCollection AddBLL(this IServiceCollection services, string? connectionString)
        {
            services.AddDAL(connectionString);

            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            services.AddScoped<HeaderManager>();
            services.AddScoped<FooterManager>();
            services.AddScoped<ISocialService, SocialManager>();
            services.AddScoped<IBioService, BioManager>();
            services.AddScoped<IBlogPostService, BlogPostManager>();

            return services;
        }
    }
}
