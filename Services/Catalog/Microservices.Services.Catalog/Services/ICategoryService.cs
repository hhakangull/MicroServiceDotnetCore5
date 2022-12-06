using Microservices.Services.Catalog.Models;
using MicroServices.Services.Catalog.Dtos;
using MicroServices.Shared.Dtos;

namespace MicroServices.Services.Catalog.Services
{
    internal interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(Category category);
        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}