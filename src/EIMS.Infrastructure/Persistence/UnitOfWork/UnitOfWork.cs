using EIMS.Application.Abstractions.Persistence;

namespace EIMS.Infrastructure.Persistence.UnitOfWork;

public sealed class UnitOfWork(ApplicationDbContext dbContext) : IUnitOfWork
{
    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}