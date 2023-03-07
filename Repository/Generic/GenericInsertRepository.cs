using Application.Interfaces.Repository.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository.Generic;

public class GenericInsertRepository<T> : IGenericInsertRepository<T> where T : class
{
    private ApplicationDbContext _context;
    private DbSet<T> table;
    public GenericInsertRepository(ApplicationDbContext context)
    {
        _context = context;
        table = _context.Set<T>();
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public void Insert(T obj)
    {
        table.Add(obj);
    }
}
