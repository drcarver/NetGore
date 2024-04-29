using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    public partial class AcrobaticsModifierViewModel : StandardTableEntryViewModel, IAcrobaticsModifiersTableEntry
    {
        /// <summary>
        /// The difficulty check modifier
        /// </summary>
        [ObservableProperty]
        private int difficultyCheckModifier;
    }
}