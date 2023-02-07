using Domain.Entities;

namespace Domain.Common;
public abstract class BaseAuditableEntity
{
    public DateTime? Created { get; set; }

    public User? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public User? LastModifiedBy { get; set; }
}
