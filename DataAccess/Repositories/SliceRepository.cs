using DataAccess.Interfaces;

namespace DataAccess.Repositories;
public class SliceRepository : IRepository<Slice>
{
    public Task<Guid> Create(Slice entity)
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

    public Task<IReadOnlyCollection<Slice>> ReadMany()
    {
        throw new NotImplementedException();
    }

    public Task Update(Slice entity)
    {
        throw new NotImplementedException();
    }
}