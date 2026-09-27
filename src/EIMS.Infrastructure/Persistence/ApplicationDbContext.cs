using EIMS.Domain.Products;
using EIMS.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EIMS.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
    }
}