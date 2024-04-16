using D20.Character.Enum;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Goods.Enum;

namespace D20.Character.Interfaces;

public interface ICharacter : ICreature
{
    /// <summary>
    /// The character class
    /// </summary>
    ICharacterClass? CharacterClass { get; set; }

    /// <summary>
    /// The characters homeland.  Automatically generated
    /// </summary>
    string? Homeland { get; set; }

    /// <summary>
    /// The character racial traits
    /// </summary>
    List<TraitEnum> Traits { get; set; }

    /// <summary>
    /// The player character parents
    /// </summary>
    string? Parents { get; set; }

    /// <summary>
    /// The characters siblings
    /// </summary>
    List<ICreature> Siblings { get; set; }

    /// <summary>
    /// Hit Dice
    /// </summary>
    string? HitDice { get; set; }

    /// <summary>
    /// Armor Proficiency
    /// </summary>
    List<EquipmentCategoryEnum> ArmorProficiency { get; set; }

    /// <summary>
    /// THe weapon Proficiency for this class
    /// </summary>
    List<WeaponProficiencyEnum> WeaponProficiency { get; set; }

    /// <summary>
    /// Tools for the creation of the character
    /// </summary>
    List<EquipmentEnum> ToolProficiency { get; set; }

    /// <summary>
    /// The inventory for the creature
    /// </summary>
    List<EquipmentEnum> Equipment { get; set; }
}