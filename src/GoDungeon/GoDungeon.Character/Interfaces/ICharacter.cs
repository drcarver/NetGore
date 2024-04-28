using System.Collections.Generic;
using System.Collections.ObjectModel;

using GoDungeon.Character.Interfaces;
using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Equipment.Enum;
using GoDungeon.Monsters.Interfaces;

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
        ObservableCollection<EquipmentEnum> ArmorProficiency { get; }

        /// <summary>
        /// The weapon Proficiency for this class
        /// </summary>
        ObservableCollection<EquipmentEnum> WeaponProficiency { get; }

        /// <summary>
        /// Tools for the creation of the character
        /// </summary>
        ObservableCollection<EquipmentEnum> ToolProficiency { get; }

        /// <summary>
        /// The inventory for the creature
        /// </summary>
        Dictionary<IInventoryEntry, InventoryEntryViewModel> Inventory { get; }

        /// <summary>
        /// Saving Throws
        /// </summary>
        ObservableCollection<AbilityEnum> SavingThrows { get; }

        /// <summary>
        /// The character level
        /// </summary>
        int Level { get; }
    }
}