using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Goods.Enum;

namespace D20.Character.Models;

public interface ICharacterClassBase : IBaseObject
{
    /// <summary>
    /// The ability score prerequisite's for the class.   
    /// </summary>
    List<ClassPrerequisite> ClassPrerequisites { get; set; }

    /// <summary>
    /// The class level
    /// </summary>
    int Level { get; set; }

    /// <summary>
    /// The class enum
    /// </summary>
    ClassEnum ClassEnum { get; set; }

    /// <summary>
    /// Hit Dice
    /// </summary>
    string? HitDice { get; set; }

    /// <summary>
    /// Armor Proficiency
    /// </summary>
    List<EquipmentCategoryEnum> ArmorProficiency { get; set; }

    /// <summary>
    /// Weapon Proficiency
    /// </summary>
    List<WeaponProficiencyEnum> WeaponProficiency { get; set; }

    /// <summary>
    /// Tools
    /// </summary>
    List<EquipmentEnum> ToolProficiency { get; set; }

    /// <summary>
    /// Saving Throws
    /// </summary>
    List<AbilityEnum> SavingThrows { get; set; }

    /// <summary>
    /// Skills
    /// </summary>
    List<SkillEnum> Skills { get; set; }

    /// <summary>
    /// The description of the class background.  Used to provide
    /// a background for the character selecting this class
    /// </summary>
    IBackgroundTableEntry? Background { get; set; }

    /// <summary>
    /// The level table for the class
    /// </summary>
    public IClassLevelTable? ClassLevelTable { get; set; }
}