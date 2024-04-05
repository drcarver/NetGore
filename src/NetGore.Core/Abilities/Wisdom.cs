using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Models;

namespace NetGore.Core.Abilities;

/// <summary>
/// Wisdom reflects how attuned you are to the world 
/// around you and represents perceptiveness and 
/// intuition.
/// </summary>
public class Wisdom : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Wisdom(ILogger? logger, Creature parent)
        : base(logger, parent)
    {
        Name = "Wisdom";
        Description = "Wisdom reflects how attuned you are to the world around you and represents perceptiveness and intuition.";
        Abbreviation = "WIS";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Wisdom(int baseAbility, Creature parent)
        : base(baseAbility, parent)
    {
        Name = "Wisdom";
        Description = "Wisdom reflects how attuned you are to the world around you and represents perceptiveness and intuition.";
        Abbreviation = "WIS";
    }
}
