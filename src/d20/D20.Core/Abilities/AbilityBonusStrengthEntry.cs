using System.Diagnostics.CodeAnalysis;

using D20.Core.Base;
using D20.Core.Models;

namespace D20.Core.Abilities;

public class AbilityBonusStrengthEntry : GameTableEntry 
{
    /// <summary>
    /// The range of a ability scores for this entry
    /// </summary>
    public Range Score { get; set; }

    /// <summary>
    /// The range of lbs for a Light load with this ability
    /// </summary>
    public Range LightLoad { get; set; }

    /// <summary>
    /// The range of lbs for a Medium load with this ability
    /// </summary>
    public Range MediumLoad { get; set; }

    /// <summary>
    /// The range of lbs for a Heavy load with this ability
    /// </summary>
    public Range HeavyLoad { get; set; }

    /// <summary>
    /// The ability modifier
    /// </summary>
    public int Modifier { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AbilityBonusStrengthEntry()
    {
    }
}