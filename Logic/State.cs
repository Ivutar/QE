using QE.Logic.Tool;

namespace QE.Logic;

public class State
{
    public string Id { get; set; }
    public IValue<bool> Bool { get; set; }
    public IValue<double> Number { get; set; }
    public IValue<string> Text { get; set; }
}