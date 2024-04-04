using System.Diagnostics.CodeAnalysis;

using NetGore.CharacterClasses.Enum;
using NetGore.Core.Abilities;
using NetGore.Core.Base;
using NetGore.Core.Models;
using NetGore.Data.Enum;

namespace NetGore.CharacterClasses.Models;

public class CharacterClassBase : BaseObject
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public CharacterClassBase()
    {
    }

    /// <summary>
    /// Hit Dice
    /// </summary>
    public string? HitDice {  get; set; }

    /// <summary>
    /// Armor Proficiency
    /// </summary>
    public List<ArmorCategoryEnum> ArmorCategory { get; set; } = [];

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
    public List<AbilityBase> SavingThrows { get; set; } = [];

    /// <summary>
    /// Skills
    /// </summary>
    public List<SkillEnum> Skills { get; set; } = [];

    /// <summary>
    /// Equipment
    /// </summary>
    public List<EquipmentEnum> Equipment { get; set; } = [];
}
