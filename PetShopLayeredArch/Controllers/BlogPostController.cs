using Microsoft.AspNetCore.Mvc;
using PetShop.BLL.Manager;
using PetShop.BLL.Services;
using PetShop.MVC.Models;

namespace PetShop.MVC.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 3;
            int skip = (page - 1) * pageSize;

            var listBlogPost = await _blogPostService.GetAllAsync();
            var listTake = listBlogPost
                .Skip(skip)
                .Take(pageSize)
                .ToList();

            var totalPosts = listBlogPost.Count();
            var totalPages = (int)Math.Ceiling(totalPosts / (double)pageSize);

            var list = new BlogPostViewModel
            {
                BlogPosts = listTake,
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View(list);
        }

    }
}
