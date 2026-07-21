using EIMS.Application.Exceptions;
using EIMS.Application.Products.Repositories;
using EIMS.Domain.Products;
using System.Data;

namespace EIMS.Application.Products.Commands.CreateProduct;

public class CreateProductCommandHandler(IProductRepository productRepository)
{
    public async Task<CreateProductResponse> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command, nameof(command));

        if(await productRepository.ExistsByNameAsync(command.Name, cancellationToken))
        {
            throw new ProductAlreadyExistsException($"Product with {command.Name} already exists.");
        }

        var product = Product.Create(command.Name, command.Description);

        await productRepository.AddAsync(product, cancellationToken);

        return new CreateProductResponse(product.Id);
    }
}
