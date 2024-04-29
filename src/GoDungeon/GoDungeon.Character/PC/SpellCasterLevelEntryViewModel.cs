using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Character.ViewModels;

namespace GoDungeon.Character.PC
{
    public partial class SpellCasterLevelEntryViewModel : ClassFeatureLevelEntryViewModel
    {
        /// <summary>
        /// Level 0 spells
        /// </summary>
        [ObservableProperty]
        private int cantripsKnown;

        /// <summary>
        /// Spell slots at this level
        /// </summary>
        [ObservableProperty]
        private int[]? spellSlots;
    }
}
