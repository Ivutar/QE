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

Console.WriteLine(clock_tower.Description.Value);
Console.WriteLine(bomb_state.Number.Value);
