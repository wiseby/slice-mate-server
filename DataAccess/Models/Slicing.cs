using DataAccess.Interfaces;

namespace DataAccess.Models;
public class Slicing : IVersionEntity
{
    public int Version { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public IEnumerable<SlicingChanges> Changes { get; set; }
    public IEnumerable<string>? ImagePaths { get; set; } = new List<string>();
    public string? GCodesPath { get; set; }
    public string? SettingsPath { get; set; }

    public Slicing(int version, IEnumerable<SlicingChanges> changes)
    {
        Version = version;
        Changes = changes;
    }
}
