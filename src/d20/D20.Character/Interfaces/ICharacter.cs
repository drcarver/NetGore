using D20.Character.Enum;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Goods.Enum;

namespace D20.Character.Interfaces;

public interface ICharacter : ICreature
{
    /// <summary>
    /// The character class
    /// </summary>
    ICharacterClass? CharacterClass { get; }

    /// <summary>
    /// The characters homeland.  Automatically generated
    /// </summary>
    IBackgroundTableEntry? Homeland { get; }

    /// <summary>
    /// The character racial traits
    /// </summary>
    List<TraitEnum> Traits { get; }

    /// <summary>
    /// The player character parents
    /// </summary>
    IBackgroundTableEntry? Parents { get; }

    /// <summary>
    /// The characters siblings
    /// </summary>
    List<ICreature> Siblings { get; }

    /// <summary>
    /// Armor Proficiency
    /// </summary>
    List<EquipmentEnum> ArmorProficiency { get; }

    /// <summary>
    /// The weapon Proficiency for this class
    /// </summary>
    List<EquipmentEnum> WeaponProficiency { get; }

    /// <summary>
    /// Tools for the creation of the character
    /// </summary>
    List<EquipmentEnum> ToolProficiency { get; }

    /// <summary>
    /// The inventory for the creature
    /// </summary>
    Dictionary<IInventoryEntry, InventoryEntry> Inventory { get; }

    /// <summary>
    /// Saving Throws
    /// </summary>
    List<AbilityEnum> SavingThrows { get; }

    /// <summary>
    /// The character level
    /// </summary>
    int Level { get; }
}