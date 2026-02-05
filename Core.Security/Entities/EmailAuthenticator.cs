// ReSharper disable InconsistentNaming
using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class EmailAuthenticator : BaseEntity<int>
{
    public int UserId { get; set; }
    public string? ActivationKey { get; set; }
    public bool IsVerified { get; set; }

    public virtual User User { get; set; } = null!;

    public EmailAuthenticator() { }

    public EmailAuthenticator(int userId, bool isVerified)
    {
        UserId = userId;
        IsVerified = isVerified;
    }

    public EmailAuthenticator(int Id, int userId, bool isVerified)
        : base(Id)
    {
        UserId = userId;
        IsVerified = isVerified;
    }
}