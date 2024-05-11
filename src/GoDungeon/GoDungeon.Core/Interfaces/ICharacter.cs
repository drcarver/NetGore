using System.Collections.Generic;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
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
        ObservableCollection<int> ArmorProficiency { get; }

        /// <summary>
        /// The weapon Proficiency for this class
        /// </summary>
        ObservableCollection<int> WeaponProficiency { get; }

        /// <summary>
        /// Tools for the creation of the character
        /// </summary>
        ObservableCollection<int> ToolProficiency { get; }

        /// <summary>
        /// The inventory for the creature
        /// </summary>
        ObservableCollection<IInventoryEntry> Inventory { get; }

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