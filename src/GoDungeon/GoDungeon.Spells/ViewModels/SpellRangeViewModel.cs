using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Spells.Enum;
using GoDungeon.Spells.Interfaces;

namespace GoDungeon.Spells.ViewModels
{
    public partial class SpellRangeViewModel : ObservableObject, ISpellRange
    {
        /// <summary>
        /// The spell effect 
        /// </summary>
        [ObservableProperty]
        private SpellEffectTypeEnum spellEffectType = SpellEffectTypeEnum.Radius;

        /// <summary>
        /// The range type
        /// </summary>
        [ObservableProperty]
        private SpellDistanceTypeEnum rangeType = SpellDistanceTypeEnum.Ranged;

        /// <summary>
        /// The distance
        /// </summary>
        [ObservableProperty]
        private int unit = 0;

        /// <summary>
        /// The type of distance
        /// </summary>
        [ObservableProperty]
        private SpellDistanceEnum distanceType = SpellDistanceEnum.Feet;
    }
}