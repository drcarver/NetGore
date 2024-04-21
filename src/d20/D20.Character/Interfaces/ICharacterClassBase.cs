using D20.Character.Interfaces;
using D20.Core.Abilities;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Goods.Enum;
using D20.Goods.Interfaces;

namespace D20.Character.Models;

public interface ICharacterClassBase : IBaseObject
{
    /// <summary>
    /// The class level
    /// </summary>
    int Level { get; }

    /// <summary>
    /// Hit Dice
    /// </summary>
    string? HitDice { get; }

    /// <summary>
    /// Armor Proficiency
    /// </summary>
    Dictionary<EquipmentEnum, IArmorEntry> ArmorProficiency { get; }

    /// <summary>
    /// Weapon Proficiency
    /// </summary>
    Dictionary<EquipmentEnum, IWeaponEntry> WeaponProficiency { get; }

    /// <summary>
    /// Tools
    /// </summary>
    Dictionary<EquipmentEnum, IGoodsTableEntry> ToolProficiency { get; }

    /// <summary>
    /// Saving Throws
    /// </summary>
    Dictionary<AbilityEnum, AbilityBase> SavingThrows { get; }

    /// <summary>
    /// Skills
    /// </summary>
    Dictionary<SkillEnum, ISkill> Skills { get; }

    /// <summary>
    /// The description of the class background.  Used to provide
    /// a background for the character selecting this class
    /// </summary>
    IBackgroundTableEntry? Background { get; }

    /// <summary>
    /// The level table for the class
    /// </summary>
    public IClassLevelTable? ClassLevelTable { get; }
}