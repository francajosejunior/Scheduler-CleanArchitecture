using Application.Interfaces.Repository.Generic;

namespace Repository.Generic;

public class GenericCommitRepository<T> : IGenericCommitRepository<T> where T : class
{

    private ApplicationDbContext _context;

    public GenericCommitRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Commit()
    {
        _context.SaveChanges();
    }
}
