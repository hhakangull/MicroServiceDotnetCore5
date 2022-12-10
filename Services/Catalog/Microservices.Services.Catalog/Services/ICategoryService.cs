using MicroServices.Services.Catalog.Dtos;
using MicroServices.Shared.Dtos;

namespace MicroServices.Services.Catalog.Services
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(CategoryDto category);
        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}