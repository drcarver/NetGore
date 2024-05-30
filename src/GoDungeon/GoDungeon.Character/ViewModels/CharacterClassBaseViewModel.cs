using System.Collections.Generic;
using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Abilities;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.Monsters.ViewModels;

namespace GoDungeon.Character.ViewModels
{
    public partial class CharacterClassBaseViewModel : BaseObjectViewModel, ICharacterClass
    {
        /// <summary>
        /// The ability score prerequisite's for the class.   
        /// </summary>
        protected List<IClassPrerequisite> classPrerequisites = new List<IClassPrerequisite>();

        /// <summary>
        /// The class enum for the class
        /// </summary>
        [ObservableProperty]
        private ClassEnum classEnum;
        
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
        private ObservableCollection<ISavingThrow> savingThrows = new ObservableCollection<ISavingThrow>();

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
        private IRandomTable? backgroundTable;

        /// <summary>
        /// The level table for the class
        /// </summary>
        [ObservableProperty]
        private IClassLevelTable? classLevelTable;

        /// <summary>
        /// The proficiency bonus for this class level 
        /// </summary>
        [ObservableProperty]
        private int proficiencyBonus;

        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character">The character we are leveling</param>
        public virtual void LevelUp(ICharacterRace character)
        {
            if (character.Level == 0)
            {
                Initialize(character);
            }
        }

        /// <summary>
        /// Initialize the character
        /// </summary>
        protected virtual void Initialize(ICharacterRace character)
        {
        }

        /// <summary>
        /// Returns true if the character has the prerequisites for the class
        /// </summary>
        /// <returns></returns>
        public bool HasPrerequisites(ICharacterRace character)
        {
            foreach (var prerequisite in classPrerequisites)
            {
                if (!prerequisite.AbilityAcceptable(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
