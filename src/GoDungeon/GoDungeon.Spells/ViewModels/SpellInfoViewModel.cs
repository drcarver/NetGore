using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;
using GoDungeon.Spells.Enum;
using GoDungeon.Spells.Interfaces;

namespace GoDungeon.Spells.ViewModels
{
    public partial class SpellInfoViewModel : StandardTableEntryViewModel, ISpell
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
        /// The magic school of Spell
        /// </summary>
        [ObservableProperty]
        private MagicSchoolEnum magicSchool;

        /// <summary>
        /// The classes that can use the spell
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<ClassEnum>? casters = new ObservableCollection<ClassEnum>();
    }
}
