namespace DataAccess.Models;
public class SlicingChanges
{
    public string Name { get; set; }
    public string OldValue { get; set; }
    public string NewValue { get; set; }

    public SlicingChanges(string name, string oldValue, string newValue)
    {
        Name = name;
        OldValue = oldValue;
        NewValue = newValue;
    }
}