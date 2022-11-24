using QE.Logic;
using QE.Logic.Tool;

var castle = new Location()
{
    Id = "CASTLE",
    Title = "Старый замок",
    Description = new SimpleValue<string>()
    {
        Value = "Старый заброшенный замок. Бла бла бла."
    }
};

var clock_tower = new Location()
{
    Id = "CLOCK_TOWER",
    Title = "Башня с часами",
    Description = new StringTimeValue()
    {
        Value = "Покосившаяся башня с часами. На часах {0}."
    }
};

var bomb_state = new State()
{
    Id = "NUMBER_BOMB_TIMER",
    //Bool = new SimpleValue<bool>() { Value = true }
    Number = new SimpleValue<double>() { Value = 10 }
};

var way_to_clock_tower = new Way()
{
    FromId = "CASTLE",
    ToId = "CLOCK_TOWER",
    Title = "Подойти к башне с часами"
};

var way_to_cave = new Way()
{
    FromId = "CASTLE",
    ToId = "CAVE",
    Title = "Забраться в пещеру",
    //Visible = new LuaValue<bool>("return states['have_light'].Bool.Value")
};

Console.WriteLine(clock_tower.Description.Value);
Console.WriteLine(bomb_state.Number.Value);
