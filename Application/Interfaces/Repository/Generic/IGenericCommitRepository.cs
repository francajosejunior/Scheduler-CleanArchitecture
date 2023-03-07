namespace Application.Interfaces.Repository.Generic;

public interface IGenericCommitRepository<T> where T : class
{
    void Commit();
}
