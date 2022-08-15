using DataAccess.Interfaces;

public class Slice : IEntityBase
{
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public string? Name { get; set; }
}