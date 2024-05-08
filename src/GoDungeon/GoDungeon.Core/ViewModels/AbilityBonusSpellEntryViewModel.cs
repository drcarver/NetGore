using System;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Models;

namespace GoDungeon.Core.ViewModels
{
    public partial class AbilityBonusSpellEntryViewModel : GameTableEntryViewModel, IAbilityBonusSpellEntry
    {
        [ObservableProperty]
        private Range score;

        [ObservableProperty]
        private int modifier;

        [ObservableProperty]
        int[]? bonusSpells;
    }
}
