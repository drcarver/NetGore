namespace NetGore.Core.Interfaces;

public interface IAbilityBase
{
    /// <summary>
    /// The base ability from the total of dice roll
    /// </summary>
    int BaseAbility { get; }

    /// <summary>
    /// The seperate dice rolls
    /// </summary>
    int[] Rolls { get; }

    /// <summary>
    /// The abbrieviation for the ability
    /// </summary>
    string Abbrieviation { get; }

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
    public string ModiferDescription { get; }

    /// <summary>
    /// The ability scores with all modifiers
    /// </summary>
    /// <returns>The current ability score with all modifiers</returns>
    int Ability();
}