using EIMS.Application.Abstractions.Persistence;
using EIMS.Application.Exceptions;
using EIMS.Application.Products.Repositories;
using EIMS.Domain.Products;

namespace EIMS.Application.Products.Commands.CreateProduct;

public class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
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

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return new CreateProductResponse(product.Id);
    }
}
