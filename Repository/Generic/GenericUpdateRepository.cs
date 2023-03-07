using Application.Interfaces.Repository.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository.Generic;

public class GenericUpdateRepository<T> : IGenericUpdateRepository<T> where T : class
{
    private ApplicationDbContext _context;
    private DbSet<T> table;
    public GenericUpdateRepository(ApplicationDbContext context)
    {
        _context = context;
        table = _context.Set<T>();
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public void Update(T obj)
    {
        table.Attach(obj);
        _context.Entry(obj).State = EntityState.Modified;
    }
}
