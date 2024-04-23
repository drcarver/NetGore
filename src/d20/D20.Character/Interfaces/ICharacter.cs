using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;
using D20.Monsters.Interfaces;

namespace D20.Character.Interfaces;

public interface ICharacter : ICharacterRace
{
    /// <summary>
    /// The character class
    /// </summary>
    ICharacterClass? CharacterClass { get; }

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