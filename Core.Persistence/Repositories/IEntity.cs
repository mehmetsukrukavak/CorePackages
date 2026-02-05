namespace Core.Persistence.Repositories;

public interface IEntity
{
    int ModifiedUserId { get; set; }
    /// <summary>
    /// if deleted = 0
    /// else 1
    /// </summary>
    Status StatusId { get; set; }
    DateTime ModifiedDate { get; set; }
}