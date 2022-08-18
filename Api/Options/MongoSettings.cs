namespace Api.Options;
public class MongoDb
{
    public const string Position = "MongoDb";
    public string ConnectionString { get; set; } = null!;
    public string Database { get; set; } = null!;
}
