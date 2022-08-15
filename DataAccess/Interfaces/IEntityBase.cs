namespace DataAccess.Interfaces;
public interface IEntityBase
{
    int Id { get; set; }
    DateTime Created { get; set; }
    DateTime Updated { get; set; }
}