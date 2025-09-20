using AutoMapper;
using PetShop.BLL.DTOs.Bio;
using PetShop.BLL.DTOs.Category;
using PetShop.BLL.Services;
using PetShop.DAL.Entities;
using PetShop.DAL.Repositories.Interfaces;

namespace PetShop.BLL.Manager
{
    public class BioManager : CrudManager<Bio, BioDto, CreateBioDto, UpdateBioDto>, IBioService
    {
        public BioManager(IRepository<Bio> respository, IMapper mapper) : base(respository, mapper)
        {
        }

    }
    public class CategoryManager : CrudManager<Category, CategoryDto, CreateCategoryDto, UpdateCategoryDto>, ICategoryService
    {
        public CategoryManager(IRepository<Category> respository, IMapper mapper) : base(respository, mapper)
        {
        }

    }
}
