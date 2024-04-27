using GoDungeon.Monsters.Interfaces;
using D20.Character.Models;

namespace GoDungeon.Character.Interfaces
{
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
}