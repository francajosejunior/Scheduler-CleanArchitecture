﻿using Application.Common.Interfaces;
using Application.Exceptions;
using Application.Schedulers.Commands;
using Domain.Entities;
using MediatR;

namespace Application.Schedulers.Handlers
{
    public class CreateScheduleCommandhHandler : IRequestHandler<SaveScheduleCommand>
    {

        private readonly IApplicationDbContext _context;

        public CreateScheduleCommandhHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(SaveScheduleCommand request, CancellationToken cancellationToken)
        {

            Schedule schedule = new Schedule
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                StartsAt = request.StartsAt,
                EndsAt = request.EndsAt,
                Created = DateTime.Now,
                CreatedBy = request.User,
                Tags = request.Tags,
            };

            _context.Schedule.Add(schedule);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}