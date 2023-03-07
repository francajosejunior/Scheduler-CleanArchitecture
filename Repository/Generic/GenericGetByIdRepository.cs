using Application.Interfaces.Repository.Generic;

namespace Repository.Generic;

public class GenericGetByIdRepository<T> : IGenericGetByIdRepository<T> where T : class
{
    private ApplicationDbContext _context;

    public GenericGetByIdRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public T GetById(object id)
    {
       return _context.Set<T>().Find(id)!;
    }
}