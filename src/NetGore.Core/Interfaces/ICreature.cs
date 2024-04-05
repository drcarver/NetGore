using NetGore.Core.Abilities;

namespace NetGore.Core.Interfaces;

public interface ICreature
{
    Charisma? Charisma { get;  }
    Constitution? Constitution { get;  }
    Dexterity? Dexterity { get;  }
    Intelligence? Intelligence { get; }
    Strength? Strength { get; }
    Wisdom? Wisdom { get; }
}