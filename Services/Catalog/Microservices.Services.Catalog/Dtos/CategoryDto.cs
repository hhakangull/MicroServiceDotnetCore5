using System.Diagnostics.CodeAnalysis;
using MongoDB.Bson;

namespace MicroServices.Services.Catalog.Dtos
{
    public class CategoryDto
    {

        public string? Id { get; set; }

    
        public string Name { get; set; }
    }
}
