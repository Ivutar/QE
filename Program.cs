using QE.Logic;
using QE.Logic.Tool;

const string LOC_TOP = "LOC_TOP";
const string LOC_BOTTOM = "LOC_BOTTOM";
const string STATE_STONE_ON_TOP = "STATE_STONE_ON_TOP";

var q = new Quest();

q.CurrentLocationId = LOC_BOTTOM;

q.Locations[LOC_TOP] = new Location()
{
    Id = LOC_TOP,
    Title = "Вершина горы",
    Description = new LuaValue<string>(q.lua, "...")
};

q.Locations[LOC_BOTTOM] = new Location()
{
    Id = LOC_BOTTOM,
    Title = "Подножие горы",
    Description = new LuaValue<string>(q.lua, "...")
};

q.States[STATE_STONE_ON_TOP] = new State()
{
    Id = STATE_STONE_ON_TOP,
    Bool = new SimpleValue<bool>() { Value = false }
};

q.Ways.Add(new Way()
{
    FromId = LOC_TOP,
    ToId = LOC_BOTTOM,
    Title = "Спуститься"
});

q.Ways.Add(new Way()
{
    FromId = LOC_BOTTOM,
    ToId = LOC_TOP,
    Title = "Подняться"
});

