using EIMS.Domain.Products;
using EIMS.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EIMS.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
    }
}