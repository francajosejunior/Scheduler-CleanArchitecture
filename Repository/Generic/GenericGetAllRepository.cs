using Application.Interfaces.Repository.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository.Generic;

public class GenericGetAllRepository<T> : IGenericGetAllRepository<T> where T : class
{
    private ApplicationDbContext _context;

    private DbSet<T> table;

    public GenericGetAllRepository(ApplicationDbContext context)
    {
        _context = context;
        table = _context.Set<T>();
    }
    public IEnumerable<T> GetAll()
    {
        return table.ToList();
    }
}