using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Models;

namespace GoDungeon.Core.ViewModels
{
    public partial class AbilityBonusSpellEntryViewModel : AbilityBonusEntryViewModel, IAbilityBonusSpellEntry
    {
        [ObservableProperty]
        int[]? bonusSpells;
    }
}
