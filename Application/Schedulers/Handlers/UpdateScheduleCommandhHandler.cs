using Application.Exceptions;
using Application.Interfaces.Repository;
using Application.Schedulers.Commands;
using Domain.Entities;
using MediatR;

namespace Application.Schedulers.Handlers
{
    public class UpdateScheduleCommandhHandler : IRequestHandler<UpdateScheduleCommand>
    {

        private readonly IApplicationDbContext _context;

        public UpdateScheduleCommandhHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateScheduleCommand request, CancellationToken cancellationToken)
        {

            var schedule = await _context.Schedule.FindAsync(request.Id, cancellationToken);

            if (schedule is null) throw new EntityNotFoundException();

            schedule.Name = request.Name;
            schedule.Description = request.Description;
            schedule.StartsAt = request.StartsAt;
            schedule.EndsAt = request.EndsAt;
            schedule.LastModified = DateTime.Now;
            schedule.LastModifiedBy = request.User;


            await _context.SaveChangesAsync(cancellationToken);

        }
    }
}
