using DataAccess.Models;

namespace DataAccess.Interfaces;
public interface ISliceService
{
    public Task<Slice> Read(Guid id);
    public Task<IReadOnlyCollection<Slice>> ReadMany(string search, int cursor);
    public Task<int> Create(Slice entity);
    public Task Update(Guid id, Slice entity);
    public Task Delete(Guid id);
}