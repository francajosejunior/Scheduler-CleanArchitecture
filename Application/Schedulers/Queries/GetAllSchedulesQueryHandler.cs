using Application.Interfaces.Repository.Generic;
using Domain.Entities;
using MediatR;

namespace Application.Schedulers.Queries;

public class GetAllSchedulesQueryHandler : IRequestHandler<GetAllSchedulesQuery, IEnumerable<Schedule>>
{
    private readonly IGenericRepository<Schedule> _repository;

    public GetAllSchedulesQueryHandler(IGenericRepository<Schedule> repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Schedule>> Handle(GetAllSchedulesQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetAll());
    }
}
