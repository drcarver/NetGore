using System.Diagnostics.CodeAnalysis;

using D20.Core.Abilities;
using D20.Core.Models;

using Microsoft.Extensions.Logging;

namespace D20.Core.Base;

public class SavingThrow : BaseObject
{
    /// <summary>
    /// The logger 
    /// </summary>
    private ILogger Logger { get; }

    /// <summary>
    /// The Id of the creature for this ability
    /// </summary>
    private Creature? Creature { get; }

    /// <summary>
    /// The ability this saving throw is based on
    /// </summary>
    private AbilityBase ability;

    /// <summary>
    /// The modifier for this saving throw (mainly from
    /// the level
    /// </summary>
    public int ProficiencyModifier { get; set; } = 0;

    /// <summary>
    /// Any class modifiers
    /// </summary>
    public int ClassModifier { get; set; } = 0;

    /// <summary>
    /// Any Other modifiers
    /// </summary>
    public int OtherModifiers { get; set; } = 0;

    /// <summary>
    /// Roll the saving throw against the give dc
    /// </summary>
    /// <param name="dc">The difficulty check for this roll</param>
    /// <returns>True if the saving throw succeeds</returns>
    public bool Roll(int dc)
    {
        var roll = new Dice("1d20").Total;
        if (roll == 1)
        {
            return false;
        }
        if (roll == 20)
        {
            return true;
        }
        return roll + ability.Score() >= dc; 
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ability">The ability for this saving throw</param>
    [SetsRequiredMembers]
    public SavingThrow(ILogger logger, AbilityBase ability, Creature creature)
        : this(ability, creature)
    {
        Logger = logger;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ability">The ability for this saving throw</param>
    [SetsRequiredMembers]
    public SavingThrow(AbilityBase ability, Creature creature)
    {
        this.ability = ability;
        Creature = creature;
    }
}
