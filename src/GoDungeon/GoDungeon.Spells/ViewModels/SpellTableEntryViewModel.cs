using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Spells.Enum;
using GoDungeon.Spells.Interfaces;

namespace GoDungeon.Spells.ViewModels
{
    public partial class SpellTableEntryViewModel : StandardTableEntryViewModel, ISpellTableEntry
    {
        /// <summary>
        /// 1st to 9th level spells
        /// </summary>
        [ObservableProperty]
        private SpellEnum spellEnum;

        /// <summary>
        /// The Spell Level
        /// </summary>
        [ObservableProperty]
        private SpellLevelEnum level;

        /// <summary>
        /// The Type of Spell
        /// </summary>
        [ObservableProperty]
        private string? spellType;

        /// <summary>
        /// The Casting Time of the Spell
        /// </summary>
        [ObservableProperty]
        private string? castingTime;

        /// <summary>
        /// The range of the Spell
        /// </summary>
        [ObservableProperty]
        private string? spellRange;

        /// <summary>
        /// The range of the Spell
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<string>? spellComponents;

        /// <summary>
        /// The range of the Spell
        /// </summary>
        [ObservableProperty]
        private string? spellDuration;
    }
}
