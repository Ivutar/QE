using NLua;

namespace QE.Logic;

public class Quest
{
    public Lua lua;
    public string CurrentLocationId { get; set; }
    public Dictionary<string, Location> Locations;
    public List<Way> Ways;
    public Dictionary<string, Item> Items;
    public Dictionary<string, State> States;
    //todo: actions

    public Quest()
    {
        Locations = new Dictionary<string, Location>();
        Ways = new List<Way>();
        Items = new Dictionary<string, Item>();
        States = new Dictionary<string, State>();

        lua = new Lua();
        lua["Locations"] = Locations;
        lua["Ways"] = Ways;
        lua["Items"] = Items;
        lua["States"] = States;
        lua["CurrentLocationId"] = CurrentLocationId;
    }
}
