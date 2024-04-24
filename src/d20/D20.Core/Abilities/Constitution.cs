using System.Diagnostics.CodeAnalysis;

using D20.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace D20.Core.Abilities;

/// <summary>
/// Constitution measures health, stamina, and vital 
/// force.
/// </summary>
public class Constitution : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Constitution(ICreature parent)
        : base(parent)
    {
        Name = "Constitution";
        Description = "Constitution measures health, stamina, and vital force.";
        Abbreviation = "CON";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Constitution(int baseAbility, ICreature parent)
        : base(baseAbility, parent)
    {
        Name = "Constitution";
        Description = "Constitution measures health, stamina, and vital force.";
        Abbreviation = "CON";
    }
}
