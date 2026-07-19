using EIMS.Domain.Exceptions;

namespace EIMS.Domain.Products;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public ProductStatus Status { get; private set; }
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset? UpdatedAt { get; private set; }

    private Product(string name,  string? description = null)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainException("Product name cannot be empty.");

        var normalizedDescription = description?.Trim();

        Id = Guid.NewGuid();
        Name = name.Trim();
        Description = string.IsNullOrEmpty(normalizedDescription)
            ? null
            : normalizedDescription;
        Status = ProductStatus.Active;
        CreatedAt = DateTimeOffset.UtcNow;
    }

    public static Product Create(string name, string? description = null)
    {
        return new Product (name, description);
    }
}


