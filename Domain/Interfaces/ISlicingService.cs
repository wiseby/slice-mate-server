using DataAccess.Models;

namespace Domain.Interfaces;
public interface ISlicingService
{
    Task<Slicing> Read(Guid sliceId, int modelVersion, int slicingVersion);
    Task<IEnumerable<Slicing>> ReadMany(Guid sliceId, int modelVersion);
    Task Update(Guid sliceId, int modelVersion, int slicingVersion, Slicing slicing);
    Task Delete(Guid sliceId, int modelVersion, int slicingVersion);
    Task<int> Create(Guid sliceId, int modelVersion, Slicing slicing);
}