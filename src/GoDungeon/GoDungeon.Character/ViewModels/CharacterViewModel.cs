using System.Collections.Generic;
using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Character.Interfaces;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;
using GoDungeon.Equipment.Enum;

namespace GoDungeon.Character.ViewModels
{
    public partial class CharacterViewModel : CreatureViewModel, ICharacter
    {
        /// <summary>
        /// The character class
        /// </summary>
        [ObservableProperty]
        private ICharacterClass? characterClass;

        /// <summary>
        /// Armor Proficiency
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<EquipmentEnum> armorProficiency= new ObservableCollection<EquipmentEnum>();

        /// <summary>
        /// The weapon Proficiency for this class
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<EquipmentEnum> weaponProficiency = new ObservableCollection<EquipmentEnum>();

        /// <summary>
        /// Tools for the creation of the character
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<EquipmentEnum> toolProficiency = new ObservableCollection<EquipmentEnum>();

        /// <summary>
        /// The inventory for the creature
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<EquipmentEnum> equipment = new ObservableCollection<EquipmentEnum>();

        /// <summary>
        /// Saving Throws
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<AbilityEnum> savingThrows = new ObservableCollection<AbilityEnum>();

        /// <summary>
        /// The inventory for the creature
        /// </summary>
        [ObservableProperty]
        private Dictionary<IInventoryEntry, InventoryEntryViewModel> inventory = new Dictionary<IInventoryEntry, InventoryEntryViewModel>();

        /// <summary>
        /// The character level
        /// </summary>
        [ObservableProperty]
        private int level;
    }
}
