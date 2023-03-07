using Domain.Entities;

namespace Domain.Common;
public abstract class BaseAuditableEntity
{
    public DateTime? Created { get; set; }

    public virtual User? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public virtual User? LastModifiedBy { get; set; }
}
