using EIMS.Domain.Products;

namespace EIMS.Application.Products.Repositories;

public interface IProductRepository
{
    Task AddAsync(Product product, CancellationToken cancellationToken);
    Task<bool> ExistsByNameAsync(string productName, CancellationToken cancellationToken);
}
