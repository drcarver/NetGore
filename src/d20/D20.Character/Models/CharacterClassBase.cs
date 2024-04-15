using System.Diagnostics.CodeAnalysis;
using D20.Character.Interfaces;
using D20.Core.Base;
using D20.Core.Enum;
using D20.Goods.Enum;

namespace D20.Character.Models;

public class CharacterClassBase : BaseObject, ICharacterClassBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public CharacterClassBase()
    {
    }

    /// <summary>
    /// The ability score prerequisite's for the class.   
    /// </summary>
    public List<ClassPrerequisite> ClassPrerequisites { get; set; } = new List<ClassPrerequisite>();

    /// <summary>
    /// Hit Dice
    /// </summary>
    public string? HitDice { get; set; }

    /// <summary>
    /// Armor Proficiency
    /// </summary>
    public List<EquipmentCategoryEnum> ArmorProficiency { get; set; } = [];

    /// <summary>
    /// Weapon Proficiency
    /// </summary>
    public List<WeaponProficiencyEnum> WeaponProficiency { get; set; } = [];

    /// <summary>
    /// Tools
    /// </summary>
    public List<ToolProficiencyEnum> ToolProficiency { get; set; } = [];

    /// <summary>
    /// Saving Throws
    /// </summary>
    public List<AbilityEnum> SavingThrows { get; set; } = [];

    /// <summary>
    /// Skills
    /// </summary>
    public List<SkillEnum> Skills { get; set; } = [];

    /// <summary>
    /// Equipment
    /// </summary>
    public List<EquipmentEnum> Equipment { get; set; } = [];

    /// <summary>
    /// Equipment
    /// </summary>
    public List<EquipmentEnum> Armor { get; set; } = [];

    /// <summary>
    /// The description of the class background.  Used to provide
    /// a background for the character selecting this class
    /// </summary>
    public string? BackgroundDescription { get; set; }
}
