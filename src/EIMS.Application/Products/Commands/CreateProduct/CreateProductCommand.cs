namespace EIMS.Application.Products.Commands.CreateProduct;

public sealed record class CreateProductCommand(string Name, string? Description);

// When writing positional records, use pascal casing for parameters as they're the public properties of the record.


