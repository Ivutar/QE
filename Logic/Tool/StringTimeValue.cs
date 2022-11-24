namespace QE.Logic.Tool;

public class StringTimeValue : IValue<string>
{
    string _value;

    public string Value
    {
        get
        {
            return string.Format(_value, DateTime.Now);
        }
        set
        {
            _value = value;
        }
    }
}
