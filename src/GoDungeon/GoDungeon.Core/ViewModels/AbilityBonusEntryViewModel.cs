using System;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    /// <summary>
    /// The view model for a Ability Bonus Entry
    /// </summary>
    public partial class AbilityBonusEntryViewModel : ObservableObject, IAbilityBonusEntry
    {
        [ObservableProperty]
        private Range score;

        [ObservableProperty]
        private int modifier;
    }
}
