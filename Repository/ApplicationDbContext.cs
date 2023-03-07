using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repository;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Schedule> Schedule => Set<Schedule>();

    public DbSet<User> User => Set<User>();

    public DbSet<Tag> Tag => Set<Tag>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }

}
