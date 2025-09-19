using Microsoft.AspNetCore.Mvc;
using PetShop.BLL.Services;
using PetShop.MVC.Models;

namespace PetShop.MVC.Controllers
{
    public class SinglePostController : Controller
    {
        private readonly IBlogPostService _blogPostService;

        public SinglePostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var listSinglePost = await _blogPostService.GetByIdAsync(id);
            var listAllPosts = (await _blogPostService.GetAllAsync()).ToList();

            var list = new SinglePostViewModel
            {
                BlogPost = listSinglePost,
                BlogPosts = listAllPosts
            };

            return View(list);
        }
    }
}
