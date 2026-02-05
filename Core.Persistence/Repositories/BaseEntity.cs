namespace Core.Persistence.Repositories;

public class BaseEntity<TId>:IEntity
{
    public BaseEntity()
    {
        Id = default;
    }

    public BaseEntity(TId id)
    {
        Id = id;
    }
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public int CreatedUserId { get; set; }
    public int ModifiedUserId { get; set; }
    /// <summary>
    /// if deleted = 0
    /// else 1
    /// </summary>
    public required Status StatusId { get; set; }
}