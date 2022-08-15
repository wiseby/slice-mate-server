using DataAccess.Interfaces;

namespace DataAccess.Repositories;
public class VersionRepository : IRepository<Version>
{
    public Task<Guid> Create(Version entity)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Version> Read(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<Version>> ReadMany()
    {
        throw new NotImplementedException();
    }

    public Task Update(Version entity)
    {
        throw new NotImplementedException();
    }
}