using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
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
        private SpellNameEnum spellType;

        /// <summary>
        /// The Spell Level
        /// </summary>
        [ObservableProperty]
        private int level;

        /// <summary>
        /// The magic school
        /// </summary>
        [ObservableProperty]
        private MagicSchoolEnum magicSchool;

        /// <summary>
        /// The classes that can use the spell
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<ClassEnum>? casters = new ObservableCollection<ClassEnum>();

        /// <summary>
        /// The Casting Time of the Spell
        /// </summary>
        [ObservableProperty]
        private ICastingTime? castingTime;

        /// <summary>
        /// The range of the Spell
        /// </summary>
        [ObservableProperty]
        private ISpellRange? spellRange;

        /// <summary>
        /// The range of the Spell
        /// </summary>
        [ObservableProperty]
        private ISpellComponent? spellComponents;

        /// <summary>
        /// The range of the Spell
        /// </summary>
        [ObservableProperty]
        private string? spellDuration;
    }
}
