using DataAccess.Models;

namespace Domain.Interfaces;
public interface ISliceService
{
    Task<Slice> Read(Guid sliceId);
    Task<IEnumerable<Slice>> ReadMany(Guid sliceId, int modelVersion);
    Task Update(Guid sliceId, int modelVersion, int SliceVersion);
    Task Delete(Guid sliceId, int modelVersion, int SliceVersion);
    Task<Guid> Create(Guid sliceId, int modelVersion, Slice Slice);
}