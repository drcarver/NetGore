using System.Collections.Generic;
using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
{
    public interface ICharacterClass : IBaseObject
    {
        /// <summary>
        /// The class enum for the class
        /// </summary>
        public ClassEnum ClassEnum { get; set; }

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
        public ObservableCollection<ISavingThrow> SavingThrows { get; set; }

        /// <summary>
        /// The description of the class background.  Used to provide
        /// a background for the character selecting this class
        /// </summary>
        public IRandomTable? BackgroundTable { get; set; }

        /// <summary>
        /// The level table for the class
        /// </summary>
        public IClassLevelTable? ClassLevelTable { get; }

        /// <summary>
        /// The proficiency bonus for this class level 
        /// </summary>
        public int ProficiencyBonus { get; }

        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character">The character we are leveling</param>
        /// <returns>True if the character can be leveled up</returns>
        public void LevelUp(ICharacterRace creature);

        /// <summary>
        /// The character has the prerequisites for the class
        /// </summary>
        /// <returns></returns>
        public bool HasPrerequisites(ICharacterRace creature);
    }
}