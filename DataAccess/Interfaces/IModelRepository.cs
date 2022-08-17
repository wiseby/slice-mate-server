using DataAccess.Models;

namespace DataAccess.Interfaces;
public interface IModelRepository
{
    public Task<Model> Read(Guid sliceId, int modelVersion);
    public Task<IReadOnlyCollection<Model>> ReadMany(Guid sliceId, string search, int cursor);
    public Task<int> Create(Guid sliceId, Model entity);
    public Task Update(Guid sliceId, int modelVerison, Model entity);
    public Task Delete(Guid sliceId, int modelVersion);
}