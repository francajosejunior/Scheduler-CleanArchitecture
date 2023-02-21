using Domain.Entities;
using MediatR;

namespace Application.Schedulers.Commands
{
    public class UpdateScheduleCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartsAt { get; set; }

        public DateTime EndsAt { get; set; }
        public IEnumerable<string>? Tags { get; set; }

        public User User { get; set; }
    }
}
