using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Spells.Enum;
using GoDungeon.Spells.Interfaces;

namespace GoDungeon.Spells.ViewModels;

/// <summary>
/// A spell’s duration is the length of time the spell persists. A duration can be 
/// expressed in rounds, minutes, hours, or even years. Some spells specify that 
/// their effects last until the spells are dispelled or destroyed.
/// </summary>
public partial class SpellDurationViewModel : ObservableObject, ISpellDuration
{
    /// <summary>
    /// If a spell must be maintained with concentration, that fact appears in its 
    /// Duration entry, and the spell specifies how long you can concentrate on it. 
    /// You can end concentration at any time (no action required).
    /// </summary>
    [ObservableProperty]
    private bool concentration = false;

    /// <summary>
    /// Up Too a duration time
    /// </summary>
    [ObservableProperty]
    private bool upToo = false;

    /// <summary>
    /// A spell’s duration is the length of time the spell persists. A duration can be 
    /// expressed in rounds, minutes, hours, or even years. Some spells specify that 
    /// their effects last until the spells are dispelled or destroyed.
    /// </summary>
    [ObservableProperty]
    private int spellDuration = 0;

    /// <summary>
    /// The units of the spell duration (hours, minutes, etc..)
    /// </summary>
    [ObservableProperty]
    private SpellDurationUnitsEnum spellDurationUnits;
}
