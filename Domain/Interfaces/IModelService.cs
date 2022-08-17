using DataAccess.Models;

namespace Domain.Interfaces;
public interface IModelService
{
    Task<Model> Read(Guid sliceId, int modelVersion);
    Task<IEnumerable<Model>> ReadMany(Guid sliceId);
    Task Update(Guid slicelId, int modelVersion, Model model);
    Task Delete(Guid sliceId, int modelVersion);
    Task<int> Create(Guid slicelId, Model model);
}