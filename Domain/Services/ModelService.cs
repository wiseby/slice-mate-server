using DataAccess.Models;
using Domain.Interfaces;

namespace Domain.Services;
public class ModelService : IModelService
{
    public Task<int> Create(Guid sliceId, Model model)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid modelId, int modelVersion)
    {
        throw new NotImplementedException();
    }

    public Task<Model> Read(Guid modelId, int modelVersion)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Model>> ReadMany(Guid modelId)
    {
        throw new NotImplementedException();
    }

    public Task Update(Guid modelId, int modelVersion, Model model)
    {
        throw new NotImplementedException();
    }
}