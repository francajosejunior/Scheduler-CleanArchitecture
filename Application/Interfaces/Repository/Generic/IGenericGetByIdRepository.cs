namespace Application.Interfaces.Repository.Generic;

public interface IGenericGetByIdRepository<T>  where T : class
{
    T GetById(object id);
}