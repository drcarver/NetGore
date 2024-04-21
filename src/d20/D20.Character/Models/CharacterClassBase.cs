using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Core.Abilities;
using D20.Core.Base;
using D20.Core.Enum;
using D20.Goods.Enum;
using D20.Goods.Interfaces;

namespace D20.Character.Models;

public class CharacterClassBase : BaseObject, ICharacterClass
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
    protected List<ClassPrerequisite> ClassPrerequisites { get; set; } = [];

    /// <summary>
    /// The class level
    /// </summary>
    public int Level { get; protected set; } = 0;

    /// <summary>
    /// Hit Dice
    /// </summary>
    public string? HitDice { get; protected set; }

    /// <summary>
    /// Armor Proficiency
    /// </summary>
    public Dictionary<EquipmentEnum, IArmorEntry> ArmorProficiency { get; protected set; } = [];

    /// <summary>
    /// Weapon Proficiency
    /// </summary>
    public Dictionary<EquipmentEnum, IWeaponEntry> WeaponProficiency { get; protected set; } = [];

    /// <summary>
    /// Tools
    /// </summary>
    public Dictionary<EquipmentEnum, IGoodsTableEntry> ToolProficiency { get; protected set; } = [];

    /// <summary>
    /// Saving Throws
    /// </summary>
    public Dictionary<AbilityEnum, AbilityBase> SavingThrows { get; protected set; } = [];

    /// <summary>
    /// Skills
    /// </summary>
    public Dictionary<SkillEnum, ISkill> Skills { get; protected set; } = [];

    /// <summary>
    /// The description of the class background.  Used to provide
    /// a background for the character selecting this class
    /// </summary>
    public IBackgroundTableEntry? Background { get; internal set; }

    /// <summary>
    /// The level table for the class
    /// </summary>
    public IClassLevelTable? ClassLevelTable { get; protected set; }

    /// <summary>
    /// Level up the character with this class
    /// </summary>
    /// <param name="character">The character we are leveling</param>
    public virtual void LevelUp(ICharacter character)
    {
        ArgumentNullException.ThrowIfNull(character);

        if (character.Level == 0)
        {
            Initialize(character);
        }
    }

    /// <summary>
    /// Initialize the character
    /// </summary>
    protected virtual void Initialize(ICharacter character)
    {
    }
}
