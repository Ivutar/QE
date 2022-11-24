using QE.Logic.Tool;

namespace QE.Logic;

public class Way
{
    public string FromId { get; set; }
    public string ToId { get; set; }
    public string Title { get; set; }
    public IValue<bool> Visible { get; set; } = new SimpleValue<bool> { Value = true };
}