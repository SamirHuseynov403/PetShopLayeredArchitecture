using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BLL.DTOs.Category
{
    public class CreateCategoryDto
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
    }
    public class UpdateCategoryDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }
}
