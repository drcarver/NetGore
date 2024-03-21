using NetGore.Core.Ablities;

namespace NetGore.Core.Interfaces;

public interface ICreature
{
    Charisma? Charisma { get;  }
    Constitution? Constitution { get;  }
    Dexterity? Dexterity { get;  }
    Intelligence? Intelligence { get; }
    string? RaceDescription { get; set;  }
    string? RaceName { get; set; }
    Strength? Strength { get; }
    Wisdom? Wisdom { get; }
}