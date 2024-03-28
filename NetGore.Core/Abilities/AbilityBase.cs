using System.Diagnostics.CodeAnalysis;
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
    /// The dice for this ability
    /// </summary>
    public readonly Dice Dice = new("3d6+3");

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
    /// Constructor
    /// </summary>
    /// <param name="logger">The logger for the class</param>
    [SetsRequiredMembers]
    public AbilityBase(ILogger? logger)
        : this()
    {
        Logger = logger;
        logger?.LogInformation($"{Dice}");
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AbilityBase()
    {
        Rolls = Dice.Rolls;
        BaseAbility = Dice.Total;
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
