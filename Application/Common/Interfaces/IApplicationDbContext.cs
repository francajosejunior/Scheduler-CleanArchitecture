using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Schedule> Schedule { get; }

    DbSet<User> User { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
