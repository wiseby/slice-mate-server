namespace DataAccess.Interfaces;
public interface IMongoEntity : IEntityBase
{
    public Guid Id { get; init; }
}