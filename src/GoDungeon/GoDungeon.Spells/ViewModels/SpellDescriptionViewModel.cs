using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Spells.Interfaces;

namespace GoDungeon.Spells.ViewModels;

public partial class SpellDescriptionViewModel : ObservableObject, ISpellDescription
{
    /// <summary>
    /// the bold description
    /// </summary>
    [ObservableProperty]
    private string? boldDescription;

    /// <summary>
    /// the spell description
    /// </summary>
    [ObservableProperty]
    private string? spellDescription;
}
