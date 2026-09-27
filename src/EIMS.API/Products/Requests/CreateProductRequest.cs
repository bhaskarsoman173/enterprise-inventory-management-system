namespace EIMS.API.Products.Requests;

public sealed class CreateProductRequest
{
    public required string Name { get; set; }

    public string? Description { get; set; }
}
