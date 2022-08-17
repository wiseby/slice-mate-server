using DataAccess.Models;
using Domain.Interfaces;

namespace Domain.Services;
public class SliceService : ISliceService
{
    public Task<Guid> Create(Guid sliceId, int modelVersion, Slice Slice)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid sliceId, int modelVersion, int SliceVersion)
    {
        throw new NotImplementedException();
    }

    public Task<Slice> Read(Guid sliceId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Slice>> ReadMany(Guid sliceId, int modelVersion)
    {
        throw new NotImplementedException();
    }

    public Task Update(Guid sliceId, int modelVersion, int SliceVersion)
    {
        throw new NotImplementedException();
    }
}