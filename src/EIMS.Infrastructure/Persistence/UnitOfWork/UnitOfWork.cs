using EIMS.Application.Abstractions.Persistence;

namespace EIMS.Infrastructure.Persistence.UnitOfWork;

internal sealed class UnitOfWork(ApplicationDbContext dbContext) : IUnitOfWork
{
    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}