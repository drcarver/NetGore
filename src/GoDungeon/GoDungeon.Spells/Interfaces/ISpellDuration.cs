using CommunityToolkit.Mvvm.ComponentModel;
using GoDungeon.Spells.Enum;

namespace GoDungeon.Spells.Interfaces;

/// <summary>
/// A spell’s duration is the length of time the spell persists. A duration can be 
/// expressed in rounds, minutes, hours, or even years. Some spells specify that 
/// their effects last until the spells are dispelled or destroyed.
/// </summary>
public interface ISpellDuration
{
    /// <summary>
    /// If a spell must be maintained with concentration, that fact appears in its 
    /// Duration entry, and the spell specifies how long you can concentrate on it. 
    /// You can end concentration at any time (no action required).
    /// </summary>
    bool Concentration { get; set; }

    /// <summary>
    /// A spell’s duration is the length of time the spell persists. A duration can be 
    /// expressed in rounds, minutes, hours, or even years. Some spells specify that 
    /// their effects last until the spells are dispelled or destroyed.
    /// </summary>
    int SpellDuration { get; set; }

    /// <summary>
    /// A duration is up to the time
    /// </summary>
    bool UpToo { get; set; }

    /// <summary>
    /// The units of the spell duration (hours, minutes, etc..)
    /// </summary>
    SpellDurationUnitsEnum SpellDurationUnits { get; set; }
}
