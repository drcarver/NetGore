namespace D20.Core.Interfaces;

public interface IAbilityBase
{
    /// <summary>
    /// The base ability from the total of dice roll
    /// </summary>
    int BaseAbility { get; }

    /// <summary>
    /// The separate dice rolls
    /// </summary>
    int[]? Rolls { get; }

    /// <summary>
    /// The abbreviation for the ability
    /// </summary>
    string Abbreviation { get; }

    /// <summary>
    /// Any racial modifiers
    /// </summary>
    int RacialModifier { get; set; }

    /// <summary>
    /// Temporary modifiers
    /// </summary>
    int TemporaryModifier { get; set; }

    /// <summary>
    /// The reason for the modifier
    /// </summary>
    public string ModifierDescription { get; }

    /// <summary>
    /// The ability scores with all modifiers
    /// </summary>
    /// <returns>The current ability score with all modifiers</returns>
    int Score();
}