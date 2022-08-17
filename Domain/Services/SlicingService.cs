using DataAccess.Models;
using Domain.Interfaces;

namespace Domain.Services;
public class SlicingService : ISlicingService
{
    public Task<int> Create(Guid sliceId, int modelVersion, Slicing slicing)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid sliceId, int modelVersion, int slicingVersion)
    {
        throw new NotImplementedException();
    }

    public Task<Slicing> Read(Guid sliceId, int modelVersion, int slicingVersion)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Slicing>> ReadMany(Guid sliceId, int modelVersion)
    {
        throw new NotImplementedException();
    }

    public Task Update(Guid sliceId, int modelVersion, int slicingVersion, Slicing slicing)
    {
        throw new NotImplementedException();
    }
}