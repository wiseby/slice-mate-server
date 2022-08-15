namespace DataAccess.Interfaces;
public interface IRepository<TEntity> where TEntity : class, IEntityBase
{
    public Task<TEntity> Read(Guid id);
    public Task<IReadOnlyCollection<TEntity>> ReadMany();
    public Task<Guid> Create(TEntity entity);
    public Task Update(TEntity entity);
    public Task Delete(Guid id);
}