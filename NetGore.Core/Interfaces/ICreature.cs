using NetGore.Core.Ablities;

namespace NetGore.Core.Interfaces;

public interface ICreature
{
    Charisma? Charisma { get; set; }
    Constitution? Constitution { get; set; }
    Dexterity? Dexterity { get; set; }
    Intelligence? Intelligence { get; set; }
    string? RaceDescription { get; set; }
    string? RaceName { get; set; }
    Strength? Strength { get; set; }
    Wisdom? Wisdom { get; set; }
}