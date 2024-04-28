using System.Collections.Generic;
using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Background.Interfaces;
using GoDungeon.Character.Interfaces;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;
using GoDungeon.Monsters.ViewModels;

namespace GoDungeon.Character.ViewModels
{
    public partial class CharacterClassBaseViewModel : CharacterRaceViewModel, ICharacterClass
    {
        /// <summary>
        /// The ability score prerequisite's for the class.   
        /// </summary>
        [ObservableProperty]
        protected ObservableCollection<IClassPrerequisite> classPrerequisites = new ObservableCollection<IClassPrerequisite>();

        /// <summary>
        /// The class level
        /// </summary>
        [ObservableProperty]
        private int level = 0;

        /// <summary>
        /// Hit Dice
        /// </summary>
        [ObservableProperty]
        private string? hitDice;

        /// <summary>
        /// Armor Proficiency
        /// </summary>
        [ObservableProperty]
        private Dictionary<EquipmentEnum, IArmorEntry> armorProficiency = new Dictionary<EquipmentEnum, IArmorEntry>();

        /// <summary>
        /// Weapon Proficiency
        /// </summary>
        [ObservableProperty]
        private Dictionary<EquipmentEnum, IWeaponEntry> weaponProficiency = new Dictionary<EquipmentEnum, IWeaponEntry>();

        /// <summary>
        /// Tools
        /// </summary>
        [ObservableProperty]
        private Dictionary<EquipmentEnum, IEquipmentTableEntry> toolProficiency = new Dictionary<EquipmentEnum, IEquipmentTableEntry>();

        /// <summary>
        /// Saving Throws
        /// </summary>
        [ObservableProperty]
        private Dictionary<AbilityEnum, IAbilityBase> savingThrows = new Dictionary<AbilityEnum, IAbilityBase>();

        /// <summary>
        /// Skills
        /// </summary>
        [ObservableProperty]
        private Dictionary<SkillEnum, ISkill> skills = new Dictionary<SkillEnum, ISkill>();

        /// <summary>
        /// The description of the class background.  Used to provide
        /// a background for the character selecting this class
        /// </summary>
        [ObservableProperty]
        private IBackgroundTableEntry? background;

        /// <summary>
        /// The level table for the class
        /// </summary>
        [ObservableProperty]
        private IClassLevelTable? classLevelTable;

        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character">The character we are leveling</param>
        public virtual void LevelUp(ICharacter character)
        {
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
}
