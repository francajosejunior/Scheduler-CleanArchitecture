using Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
public class User 
{
    [Key]
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public string? Password { get; set; }
}
