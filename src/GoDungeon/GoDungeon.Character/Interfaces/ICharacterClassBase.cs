//using System.Collections.Generic;
//using System.Collections.ObjectModel;

//using GoDungeon.Background.Interfaces;
//using GoDungeon.Core.Enum;
//using GoDungeon.Core.Interfaces;

//namespace GoDungeon.Character.Interfaces
//{
//    public interface ICharacterClassBase : IBaseObject
//    {
//        /// <summary>
//        /// The class level
//        /// </summary>
//        int Level { get; }

//        /// <summary>
//        /// Hit Dice
//        /// </summary>
//        string? HitDice { get; }

//        /// <summary>
//        /// Armor Proficiency
//        /// </summary>
//        ObservableCollection<IArmorEntry> ArmorProficiency { get; }

//        /// <summary>
//        /// Weapon Proficiency
//        /// </summary>
//        ObservableCollection<IWeaponEntry> WeaponProficiency { get; }

//        /// <summary>
//        /// Tools
//        /// </summary>
//        //ObservableCollection<IEquipmentTableEntry> ToolProficiency { get; }

//        /// <summary>
//        /// Saving Throws
//        /// </summary>
//        ObservableCollection<AbilityEnum> SavingThrows { get; }

//        /// <summary>
//        /// Skills
//        /// </summary>
//        ObservableCollection<SkillEnum> Skills { get; }

//        /// <summary>
//        /// The description of the class background.  Used to provide
//        /// a background for the character selecting this class
//        /// </summary>
//        IBackgroundTableEntry? Background { get; }

//        /// <summary>
//        /// The level table for the class
//        /// </summary>
//        public IClassLevelTable? ClassLevelTable { get; }
//    }
//}