using System.Collections.Generic;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
{
    public interface ICharacterClass : ICharacterRace
    {
        /// <summary>
        /// The ability score prerequisite's for the class.   
        /// </summary>
        public ObservableCollection<IClassPrerequisite> ClassPrerequisites { get; set; }

        /// <summary>
        /// The class level
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Hit Dice
        /// </summary>
        public string? HitDice { get; set; }

        /// <summary>
        /// Armor Proficiency
        /// </summary>
        public ObservableCollection<int> ArmorProficiency { get; set; }

        /// <summary>
        /// Weapon Proficiency
        /// </summary>
        public ObservableCollection<int> WeaponProficiency { get; set; }

        /// <summary>
        /// Tools
        /// </summary>
        public ObservableCollection<int> ToolProficiency { get; set; }

        /// <summary>
        /// Saving Throws
        /// </summary>
        public ObservableCollection<AbilityEnum> SavingThrows { get; set; }

        /// <summary>
        /// The description of the class background.  Used to provide
        /// a background for the character selecting this class
        /// </summary>
        public IBackgroundTableEntry? Background { get; set; }

        /// <summary>
        /// The level table for the class
        /// </summary>
        public IClassLevelTable? ClassLevelTable { get; set; }

        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character">The character we are leveling</param>
        public void LevelUp(ICharacterClass character);
    }
}