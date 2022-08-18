using DataAccess.Interfaces;
using DataAccess.Models;
using MongoDB.Driver;

namespace DataAccess.Repositories;
public class SliceRepository : ISliceService
{
    private readonly IMongoCollection<Slice> _collection;

    public SliceRepository(IMongoCollection<Slice> collection)
    {
        _collection = collection;
    }

    public Task<int> Create(Slice entity)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Slice> Read(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<Slice>> ReadMany(string search, int cursor)
    {
        throw new NotImplementedException();
    }

    public Task Update(Guid id, Slice entity)
    {
        throw new NotImplementedException();
    }
}