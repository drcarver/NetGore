using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Spells.Enum;

namespace GoDungeon.Spells.Interfaces;

public interface ISpellRange
{
    /// <summary>
    /// The spell effect 
    /// </summary>
    SpellEffectTypeEnum SpellEffectType { get; set; }

    /// <summary>
    /// The range type
    /// </summary>
    SpellDistanceTypeEnum RangeType { get; set; }

    /// <summary>
    /// The distance
    /// </summary>
    int Unit { get; set; }

    /// <summary>
    /// The type of distance
    /// </summary>
    SpellDistanceEnum DistanceType { get; set; }

}