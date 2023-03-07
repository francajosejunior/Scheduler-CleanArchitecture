using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Tag
{
    [Key]
    public required string Description { get; set; }

    public virtual IEnumerable<Schedule>? Schedules { get; set; }

    public static IEnumerable<Tag>? FromListString(IEnumerable<string>? strings)
        => strings?.Select(x => new Tag { Description = x });
}