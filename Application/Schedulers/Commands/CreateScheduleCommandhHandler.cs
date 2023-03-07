using Application.Exceptions;
using Application.Interfaces.Repository;
using Application.Interfaces.Repository.Generic;
using Domain.Entities;
using MediatR;

namespace Application.Schedulers.Commands
{
    public class CreateScheduleCommandhHandler : IRequestHandler<CreateScheduleCommand, Guid>
    {
        private readonly IGenericRepository<Schedule> _repository;

        public CreateScheduleCommandhHandler(IGenericRepository<Schedule> repository)
        {
            _repository = repository;
        }

        public Task<Guid> Handle(CreateScheduleCommand request, CancellationToken cancellationToken)
        {
            Schedule schedule = new()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                StartsAt = request.StartsAt,
                EndsAt = request.EndsAt,
                Created = DateTime.Now,
                CreatedBy = request.User,
                Tags = Tag.FromListString(request.Tags),
            };

            _repository.Insert(schedule);

            _repository.Commit();

            return Task.FromResult(schedule.Id);
        }
    }
}
