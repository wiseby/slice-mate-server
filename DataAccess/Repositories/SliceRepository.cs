using DataAccess.Interfaces;
using DataAccess.Models;

namespace DataAccess.Repositories;
public class SliceRepository : ISliceService
{
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