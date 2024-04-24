using System.Diagnostics.CodeAnalysis;

using D20.Core.Models;

using Microsoft.Extensions.Logging;

namespace D20.Core.Abilities;

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
    public Wisdom(Creature parent)
        : base(parent)
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
