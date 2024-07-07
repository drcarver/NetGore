//
// Ability Scores and Modifiers view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

namespace GoDungeon.Core.Interfaces;

/// <summary>
/// IAbility Scores and Modifiers
/// </summary>
public interface IAbilityScoresandModifiers : IStandardTableEntry
{
    /// <summary>
    /// Score
    /// </summary>
    public int Score { get; set; }

    /// <summary>
    /// Modifier
    /// </summary>
    public int Modifier { get; set; }

}
