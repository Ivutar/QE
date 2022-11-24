using NLua;

namespace QE.Logic;

public class Quest
{
    Lua lua;
    public string CurrentLocationId { get; set; }
    public Dictionary<string, Location> Locations;
    public Dictionary<string, Way> Ways;
    public Dictionary<string, Item> Items;
    public Dictionary<string, State> States;

    public Quest()
    {
        //...
    }
}
