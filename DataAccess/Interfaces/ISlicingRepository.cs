using DataAccess.Models;

namespace DataAccess.Interfaces;
public interface ISlicingRepository
{
    public Task<Slicing> Read(Guid sliceId, int modelVersion, int slicingVersion);
    public Task<IReadOnlyCollection<Slicing>> ReadMany(Guid sliceId, int modelVersion);
    public Task<int> Create(Guid sliceId, int modelVersion, Slicing entity);
    public Task Update(Guid sliceId, int modelVersion, int slicingVersion, Slicing entity);
    public Task Delete(Guid sliceId, int modelVersion, int slicingVersion);
}