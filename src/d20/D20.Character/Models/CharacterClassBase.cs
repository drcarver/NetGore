using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Core.Base;
using D20.Core.Enum;
using D20.Goods.Enum;

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
    public List<ClassPrerequisite> ClassPrerequisites { get; set; } = new List<ClassPrerequisite>();

    /// <summary>
    /// The class level
    /// </summary>
    public int Level { get; set; } = 0;

    /// <summary>
    /// The class enum
    /// </summary>
    public ClassEnum ClassEnum { get; set; }

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
    public List<EquipmentEnum> ToolProficiency { get; set; } = [];

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
    public IBackgroundTableEntry? Background { get; set; }

    /// <summary>
    /// The level table for the class
    /// </summary>
    public IClassLevelTable? ClassLevelTable { get; set; }

    /// <summary>
    /// Level up the character with this class
    /// </summary>
    /// <param name="character">The character we are leveling</param>
    public virtual void LevelUp(ICharacter character)
    {
        if (character.CharacterClass == null)
        {
            character.CharacterClass = this;

            // Add any armor proficiencies
            foreach (var item in ArmorProficiency)
            {
                if (!character.ArmorProficiency.Contains(item))
                {
                    character.ArmorProficiency.Add(item);
                }
            }

            // Add any weapon proficiencies
            foreach (var item in WeaponProficiency)
            {
                if (!character.WeaponProficiency.Contains(item))
                {
                    character.WeaponProficiency.Add(item);
                }
            }

            // Add any tool proficiencies
            foreach (var item in ToolProficiency)
            {
                if (!character.ToolProficiency.Contains(item))
                {
                    character.ToolProficiency.Add(item);
                }
            }

            // Add any saving throws
            foreach (var item in SavingThrows)
            {
                if (!character.SavingThrows.Contains(item))
                {
                    character.SavingThrows.Add(item);
                }
            }

            // Add any traits
            if (Background?.Traits != null)
            {
                foreach (var item in Background.Traits)
                {
                    if (!character.Traits.Contains(item))
                    {
                        character.Traits.Add(item);
                    }
                }
            }

            // Skills are handled by the PC or NPC classes
        }
    }
}
