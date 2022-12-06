namespace MicroServices.Services.Catalog.Dtos;

internal class CourseDto
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string UserId { get; set; }

    public decimal Price { get; set; }

    public string? Picture { get; set; }

    public DateTime CreatedTime { get; set; }

    public FeatureDto Feature { get; set; }

    public string CategoryId { get; set; }

    public CategoryDto Category { get; set; }
}

internal class CourseCreateDto
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string UserId { get; set; }

    public decimal Price { get; set; }
    public string Picture { get; set; }

    public FeatureDto Feature { get; set; }

    public string CategoryId { get; set; }
}

internal class CourseUpdateDto
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string UserId { get; set; }

    public decimal Price { get; set; }

    public string Picture { get; set; }

    public FeatureDto Feature { get; set; }

    public string CategoryId { get; set; }
}