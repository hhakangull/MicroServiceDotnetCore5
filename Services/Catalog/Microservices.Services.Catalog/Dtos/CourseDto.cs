namespace MicroServices.Services.Catalog.Dtos;

public class CourseDto
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

public class CourseCreateDto
{
    public string Name { get; set; }

    public string UserId { get; set; }

    public decimal Price { get; set; }
    public string Picture { get; set; }

    public FeatureDto Feature { get; set; }

    public string CategoryId { get; set; }
}

public class CourseUpdateDto
{
    public string Name { get; set; }

    public string UserId { get; set; }

    public decimal Price { get; set; }

    public string Picture { get; set; }

    public FeatureDto Feature { get; set; }

    public string CategoryId { get; set; }
}