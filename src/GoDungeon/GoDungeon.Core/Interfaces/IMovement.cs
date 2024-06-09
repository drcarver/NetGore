using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces;

public interface IMovement
{
    /// <summary>
    /// The movement type
    /// </summary>
    MovementEnum MovementType { get; set; }

    /// <summary>
    /// The speed on ft per round
    /// </summary>
    int Speed { get; set; }

    /// <summary>
    /// The rate (usually in ft per round)
    /// </summary>
    MovementRateEnum MovementRate { get; set; }

    /// <summary>
    /// The movement modifier
    /// </summary>
    string? MovementModifier { get; set; }
}