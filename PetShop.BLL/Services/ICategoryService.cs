using PetShop.BLL.DTOs.Category;
using PetShop.DAL.Entities;

namespace PetShop.BLL.Services
{
    public interface ICategoryService : ICrudService<Category, CategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {

    }
}
