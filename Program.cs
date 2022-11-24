using QE.Logic;
using QE.Logic.Tool;

var castle = new Location()
{
    Id = "CASTLE",
    Title = "Старый замок",
    Description = new StringValue()
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

Console.WriteLine(clock_tower.Description.Value);