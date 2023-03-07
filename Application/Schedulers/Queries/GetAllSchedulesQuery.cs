using Domain.Entities;
using MediatR;

namespace Application.Schedulers.Queries;

public record GetAllSchedulesQuery : IRequest<IEnumerable<Schedule>>;
