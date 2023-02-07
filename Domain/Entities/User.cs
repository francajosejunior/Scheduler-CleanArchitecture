using Domain.Common;

namespace Domain.Entities;
public class User : BaseAuditableEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public string? Password { get; set; }
}
