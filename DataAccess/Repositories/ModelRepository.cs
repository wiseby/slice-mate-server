using DataAccess.Interfaces;
using DataAccess.Models;
using MongoDB.Driver;

namespace DataAccess.Repositories;
public class ModelRepository : IModelRepository
{
    private readonly IMongoCollection<Model> _collection;

    public ModelRepository(IMongoCollection<Model> collection)
    {
        _collection = collection;
    }

    public Task<int> Create(Guid sliceId, Model entity)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid sliceId, int modelVersion)
    {
        throw new NotImplementedException();
    }

    public Task<Model> Read(Guid sliceId, int modelVersion)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<Model>> ReadMany(Guid sliceId, string search, int cursor)
    {
        throw new NotImplementedException();
    }

    public Task Update(Guid sliceId, int modelVersion, Model entity)
    {
        throw new NotImplementedException();
    }
}