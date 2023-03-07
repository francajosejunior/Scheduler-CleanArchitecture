namespace Application.Interfaces.Repository.Generic;

public interface IGenericDeleteRepository<T> : IGenericCommitRepository<T> where T : class
{
    void Delete(object id);
}
