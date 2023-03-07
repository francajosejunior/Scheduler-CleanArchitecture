using Application.Interfaces.Repository.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository.Generic;

public class GenericDeleteRepository<T> : IGenericDeleteRepository<T> where T : class
{
    private ApplicationDbContext _context;
    private DbSet<T> table;
    public GenericDeleteRepository(ApplicationDbContext context)
    {
        _context = context;
        table = _context.Set<T>();
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public void Delete(object id)
    {
        T existing = table.Find(id)!;
        table.Remove(existing);
    }
}
