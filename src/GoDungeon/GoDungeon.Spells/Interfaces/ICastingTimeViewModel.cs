using GoDungeon.Core.Enum;

namespace GoDungeon.Spells.Interfaces;

/// <summary>
/// Most spells require a single action to cast, but some spells require a bonus action, 
/// a reaction, or much more time to cast.
/// </summary>
public interface ICastingTime
{
    /// <summary>
    /// A spell cast with a bonus action is especially swift. You must use a bonus action 
    /// on your turn to cast the spell, provided that you haven’t already taken a bonus 
    /// action this turn. You can’t cast another spell during the same turn, except for 
    /// a cantrip with a casting time of 1 action.
    /// </summary>
    int CastingTime { get; set; }

    /// <summary>
    /// A spell’s duration is the length of time the spell persists. A duration can be 
    /// expressed in rounds, minutes, hours, or even years. Some spells specify that 
    /// their effects last until the spells are dispelled or destroyed.
    /// </summary>
    DurationEnum Duration { get; set; }
}