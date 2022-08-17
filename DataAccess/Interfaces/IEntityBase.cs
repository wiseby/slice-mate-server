namespace DataAccess.Interfaces;
public interface IEntityBase
{
    DateTime Created { get; set; }
    DateTime Updated { get; set; }
}