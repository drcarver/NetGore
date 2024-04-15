using System.Diagnostics.CodeAnalysis;

using D20.Core.Base;
using D20.Core.Interfaces;

namespace D20.Core.Abilities;

public abstract class AbilityBase : DataObject, IAbilityBase
{
    /// <summary>
    /// The creature with this ability
    /// </summary>
    public ICreature Creature { get; }

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
    public int Score()
    {
        return BaseAbility
            + RacialModifier
            + GetModifier().Modifier
            + TemporaryModifier;
    }

    /// <summary>
    /// Get the modifier for this ability score from
    /// the ability modifier table
    /// </summary>
    /// <returns>The modifier for this score</returns>
    public AbilityBonusEntry? GetModifier()
    {
        //return ModifierTable.First(t =>
        //                t.Score.Start.Value >= Score()
        //             && t.Score.End.Value <= Score());
        return null;
    }

    /// <summary>
    /// Return the Ability as a string
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        var retval = Abbreviation + " ";
        for (int i = 0; i < Rolls?.Length; i++)
        {
            retval += $"Dice{i}={Rolls[i]} ";
        }
        // BaseAbility + RacialModifier + TemporaryModifier
        retval += $"BaseAbility({BaseAbility}) + ";
        retval += $"RacialModifier({RacialModifier}) + ";
        retval += $"TemporaryModifier({TemporaryModifier}) = ";
        retval += $"AbilityModifier({GetModifier().Modifier}) = ";
        retval += $" Total({Score()})";
        return retval;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="creature">The creature that has this ability</param>
    [SetsRequiredMembers]
    public AbilityBase(ICreature creature)
    {
        var dice = new Dice("4d6");
        Rolls = new int[3];
        for (int i = 0; i <= 2; i++)
        {
            Rolls[i] = dice.Rolls[i];
        }
        BaseAbility = Rolls.Sum();
        Creature = creature;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="baseAbility">The ability score.  We are not randomly generating it</param>
    /// <param name="creature">The creature that has this ability</param>
    [SetsRequiredMembers]
    public AbilityBase(int baseAbility, ICreature creature)
        : this(creature)
    {
        Rolls = null;
        BaseAbility = baseAbility;
    }
}
