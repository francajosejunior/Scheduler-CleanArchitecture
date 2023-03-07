namespace Application.Interfaces.Repository.Generic;

public interface IGenericInsertRepository<T> : IGenericCommitRepository<T> where T : class
{
    void Insert(T obj);
}
