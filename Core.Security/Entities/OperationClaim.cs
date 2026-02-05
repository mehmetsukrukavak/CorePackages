// ReSharper disable InconsistentNaming
using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class OperationClaim : BaseEntity<int>
{
    public string Name { get; set; }

    public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; } = null!;

    public OperationClaim()
    {
        Name = String.Empty;
    }

    public OperationClaim(string name)
    {
        Name = name;
    }

    public OperationClaim(int Id, string name) : base(Id)
    {
        Name = name;
    }
}