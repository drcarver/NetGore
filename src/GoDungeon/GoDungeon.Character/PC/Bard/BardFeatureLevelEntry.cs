using CommunityToolkit.Mvvm.ComponentModel;

namespace GoDungeon.Character.PC.Bard
{
    public partial class BardFeatureLevelEntryViewModel : SpellCasterLevelEntryViewModel
    {
        /// <summary>
        /// 1st to 9th level spells known
        /// </summary>
        [ObservableProperty]
        private int spellsKnown;
    }
}
