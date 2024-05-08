using System.Collections.Generic;
using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Monsters.ViewModels;

namespace GoDungeon.Character.ViewModels
{
    public partial class CharacterClassBaseViewModel : CharacterRaceViewModel, ICharacterClass
    {
        /// <summary>
        /// The ability score prerequisite's for the class.   
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<IClassPrerequisite> classPrerequisites = new ObservableCollection<IClassPrerequisite>();

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
        private ObservableCollection<int> armorProficiency = new ObservableCollection<int>();

        /// <summary>
        /// Weapon Proficiency
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<int> weaponProficiency = new ObservableCollection<int>();

        /// <summary>
        /// Tools
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<int> toolProficiency = new ObservableCollection<int>();

        /// <summary>
        /// Saving Throws
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<AbilityEnum> savingThrows = new ObservableCollection<AbilityEnum>();

        /// <summary>
        /// Skills
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<SkillEnum> skills = new ObservableCollection<SkillEnum>();

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
        public virtual void LevelUp(ICharacterClass character)
        {
            if (character.Level == 0)
            {
                Initialize(character);
            }
        }

        /// <summary>
        /// Initialize the character
        /// </summary>
        protected virtual void Initialize(ICharacterClass character)
        {
        }
    }
}
