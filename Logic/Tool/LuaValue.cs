using NLua;

namespace QE.Logic.Tool;

public class LuaValue<T> : IValue<T>
{
    Lua _lua;
    string _script;

    public LuaValue (Lua lua) => _lua = lua;
    public LuaValue (Lua lua, string script)
    {
        _lua = lua;
        _script = script;
    }

    public T Value
    {
        get
        {
            return (T)_lua.DoString($"return {_script}")[0];
        }
        set
        {
        }
    } 
}
