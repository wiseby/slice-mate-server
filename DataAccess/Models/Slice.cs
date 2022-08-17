using DataAccess.Interfaces;

namespace DataAccess.Models;
public class Slice : IMongoEntity
{
    public Guid Id { get; init; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public IEnumerable<Model> Models { get; set; }

    public Slice(string name, IEnumerable<Model> models)
    {
        Id = Guid.NewGuid();
        Name = name;
        Models = models;
        Created = DateTime.UtcNow;
        Updated = DateTime.UtcNow;
    }
}