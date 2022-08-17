using DataAccess.Interfaces;
using DataAccess.Models;

namespace DataAccess.Repositories;
public class SlicingRepository : ISlicingRepository
{
    public Task<int> Create(Guid sliceId, int modelVersion, Slicing entity)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid sliceId, int modelVersion, int slicingVersion)
    {
        throw new NotImplementedException();
    }

    public Task<Slicing> Read(Guid id, int modelVerison, int slicingVersion)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<Slicing>> ReadMany(Guid id, int modelVerison)
    {
        throw new NotImplementedException();
    }

    public Task Update(Guid id, int modelVerison, int slicingVersion, Slicing entity)
    {
        throw new NotImplementedException();
    }
}