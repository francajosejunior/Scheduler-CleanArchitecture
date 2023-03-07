namespace Application.Interfaces.Repository.Generic;

public interface IGenericGetAllRepository<T> where T : class
{
    IEnumerable<T> GetAll();
}
