using Application.Interfaces.Repository.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository.Generic;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{

    private ApplicationDbContext _context;

    private DbSet<T> table;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        table = _context.Set<T>();
    }
    public IEnumerable<T> GetAll()
    {
        return table.ToList();
    }
    public T GetById(object id)
    {
        return table.Find(id)!;
    }
    public void Insert(T obj)
    {
        table.Add(obj);
    }
    public void Update(T obj)
    {
        table.Attach(obj);
        _context.Entry(obj).State = EntityState.Modified;
    }
    public void Delete(object id)
    {
        T existing = table.Find(id)!;
        table.Remove(existing);
    }
    public void Commit()
    {
        _context.SaveChanges();
    }
}