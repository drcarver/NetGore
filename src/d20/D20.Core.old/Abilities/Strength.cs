using System.Diagnostics.CodeAnalysis;

using D20.Core.Interfaces;

namespace D20.Core.Abilities;

/// <summary>
/// Strength measures bodily power, athletic training, 
/// and the extent to which you can exert raw physical 
/// force.
/// </summary>
public class Strength : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Strength(ICreature parent)
        : base(parent)
    {
        Name = "Strength";
        Description = "Strength measures bodily power, athletic training, and the extent to which you can exert raw physical force.";
        Abbreviation = "STR";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Strength(int baseAbility, ICreature parent)
        : base(baseAbility, parent)
    {
        Name = "Strength";
        Description = "Strength measures bodily power, athletic training, and the extent to which you can exert raw physical force.";
        Abbreviation = "STR";
    }
}
