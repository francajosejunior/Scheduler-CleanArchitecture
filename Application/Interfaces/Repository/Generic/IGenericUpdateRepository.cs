namespace Application.Interfaces.Repository.Generic;

public interface IGenericUpdateRepository<T> : IGenericCommitRepository<T> where T : class
{
    void Update(T obj);
}
