using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

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
        private ObservableCollection<int> armorProficiency= new ObservableCollection<int>();

        /// <summary>
        /// The weapon Proficiency for this class
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<int> weaponProficiency = new ObservableCollection<int>();

        /// <summary>
        /// Tools for the creation of the character
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<int> toolProficiency = new ObservableCollection<int>();

        /// <summary>
        /// The inventory for the creature
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<int> equipment = new ObservableCollection<int>();

        /// <summary>
        /// Saving Throws
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<AbilityEnum> savingThrows = new ObservableCollection<AbilityEnum>();

        /// <summary>
        /// The inventory for the creature
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<IInventoryEntry> inventory = new ObservableCollection<IInventoryEntry>();

        /// <summary>
        /// The character level
        /// </summary>
        [ObservableProperty]
        private int level;
    }
}
