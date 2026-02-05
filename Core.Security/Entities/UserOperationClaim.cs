// ReSharper disable InconsistentNaming
using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class UserOperationClaim: BaseEntity<int>
{
    public int UserId { get; set; }
    public int OperationClaimId { get; set; }

    public virtual User User { get; set; }
    public virtual OperationClaim OperationClaim { get; set; }

    public UserOperationClaim(int userId, int operationClaimId)
    {
        UserId = userId;
        OperationClaimId = operationClaimId;
    }

    public UserOperationClaim(int Id, int userId, int operationClaimId) : base(Id)
    {
        UserId = userId;
        OperationClaimId = operationClaimId;
    }
}