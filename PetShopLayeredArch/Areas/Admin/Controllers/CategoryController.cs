using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShop.BLL.DTOs.Category;
using PetShop.BLL.Services;
using PetShop.DAL.Data;
using PetShop.DAL.Entities;
using PetShop.MVC.Areas.Admin.Controllers;


namespace PetShop.MVC.Areas.Admin.Controllers
{
    public class CategoryController : AdminController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _categoryService.GetAllAsync();
            return View(list);
        }
        public async Task<IActionResult> Create(CreateCategoryDto category)
        {
            await _categoryService.CreateAsync(category);
            return View();
        }
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null) return NotFound();
            await _categoryService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null) return NotFound();
            var categoryUpdateDto = new UpdateCategoryDto
            {
                Name = category.Name,
            };

            return View(categoryUpdateDto);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateCategoryDto categoryDto)
        {
            var category = await _categoryService.GetByIdAsync(categoryDto.Id);
            if (category == null) return NotFound();
            await _categoryService.UpdateAsync(categoryDto.Id,categoryDto);
            return RedirectToAction("Index");
        }
    }
}
