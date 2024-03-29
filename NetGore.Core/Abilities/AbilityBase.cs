using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

using Microsoft.Extensions.Logging;

using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Abilities;

public abstract class AbilityBase : BaseObject, IAbilityBase
{
    /// <summary>
    /// The injected logger for the service. 
    /// </summary>
    private ILogger? Logger { get; set; }

    /// <summary>
    /// The base ability from the total of dice roll
    /// </summary>
    public int BaseAbility { get; private set; }

    /// <summary>
    /// The separate dice rolls
    /// </summary>
    public int[]? Rolls { get; private set; }

    /// <summary>
    /// The abbreviation for the ability
    /// </summary>
    public string Abbreviation { get; protected set; } = string.Empty;

    /// <summary>
    /// Any racial modifiers
    /// </summary>
    public int RacialModifier { get; set; } = 0;

    /// <summary>
    /// Temporary modifiers
    /// </summary>
    public int TemporaryModifier { get; set; } = 0;

    /// <summary>
    /// The reason for the modifier
    /// </summary>
    public string ModifierDescription { get; internal set; } = string.Empty;

    /// <summary>
    /// The ability scores with all modifiers
    /// </summary>
    /// <returns>The current ability score with all modifiers</returns>
    public int Ability()
    {
        return BaseAbility + RacialModifier + TemporaryModifier;
    }

    /// <summary>
    /// Return the Ability as a string
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        var retval = Abbreviation + " ";
        for (int i = 0; i < Rolls?.Length; i ++)
        {
            retval += $"Dice{i}={Rolls[i]} ";
        }
        // BaseAbility + RacialModifier + TemporaryModifier
        retval += $"BaseAbility({BaseAbility}) + ";
        retval += $"RacialModifier({RacialModifier}) + ";
        retval += $"TemporaryModifier({TemporaryModifier}) = ";
        retval += $" Total({Ability()})";
        return retval;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger">The logger for the class</param>
    [SetsRequiredMembers]
    public AbilityBase(ILogger? logger)
        : this()
    {
        Logger = logger;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AbilityBase()
    {
        var dice = new Dice("4d6");
        Rolls = new int[3];
        for (int i = 0; i <= 2; i++)
        {
            Rolls[i] = dice.Rolls[i];
        }
        BaseAbility = Rolls.Sum();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AbilityBase(int baseAbility)
    {
        Rolls = null;
        BaseAbility = baseAbility;
    }
}
