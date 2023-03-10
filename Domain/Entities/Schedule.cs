using Domain.Common;
using Domain.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
public class Schedule : BaseAuditableEntity
{
    [Key]
    public required Guid Id { get; set; }

    public required string Name { get; set; }
    public string? Description { get; set; }

    private DateTime? startsAt = null;
    public required DateTime StartsAt
    {
        get => startsAt!.Value;
        set
        {
            if (endsAt is not null && value > endsAt)
                throw new SchedulerInvertedDatesException();

            startsAt = value;
        }
    }

    private DateTime? endsAt = null;

    public required DateTime EndsAt
    {
        get => endsAt!.Value!;
        set
        {
            if (startsAt is not null && startsAt > value)
                throw new SchedulerInvertedDatesException();

            endsAt = value;
        }
    }
    public virtual IEnumerable<Tag>? Tags { get; set; }
}
