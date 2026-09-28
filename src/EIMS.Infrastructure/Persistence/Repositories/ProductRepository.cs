using EIMS.Application.Products.Repositories;
using EIMS.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace EIMS.Infrastructure.Persistence.Repositories;

public sealed class ProductRepository(ApplicationDbContext dbContext) : IProductRepository
{
    public async Task AddAsync(Product product, CancellationToken cancellationToken)
    {
        await dbContext.Products.AddAsync(product, cancellationToken);
    }

    public async Task<bool> ExistsByNameAsync(string productName, CancellationToken cancellationToken)
    {
        return await dbContext.Products
            .AnyAsync(
                product => product.Name == productName,
                cancellationToken);
    }
}