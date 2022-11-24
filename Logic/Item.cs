using QE.Logic.Tool;

namespace QE.Logic;

public class Item
{
    public string Id { get; set; }
    public string Title { get; set; }
    public IValue<string> Description { get; set; }
    public string LocationId { get; set; } 
}