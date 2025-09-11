using PetShop.BLL.DTOs.Bio;
using PetShop.DAL.Entities;

namespace PetShop.BLL.Services
{
    public interface IBioService : ICrudService<Bio, BioDto, CreateBioDto, UpdateBioDto>
    {

    }
}
