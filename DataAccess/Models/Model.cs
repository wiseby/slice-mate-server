using DataAccess.Interfaces;

namespace DataAccess.Models;
public class Model : IEntityBase
{
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int Version { get; set; }
    public IEnumerable<Slicing> Slicings { get; set; }

    public Model(string name, int version)
    {
        Name = name;
        Version = version;
        Created = DateTime.UtcNow;
        Updated = DateTime.UtcNow;
        Slicings = new List<Slicing>();
    }
}