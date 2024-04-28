using System.Collections.Generic;

using GoDungeon.Background.Interfaces;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Character.Interfaces
{
    public interface ICharacterClassBase : IBaseObject
    {
        /// <summary>
        /// The class level
        /// </summary>
        int Level { get; }

        /// <summary>
        /// Hit Dice
        /// </summary>
        string? HitDice { get; }

        /// <summary>
        /// Armor Proficiency
        /// </summary>
        Dictionary<EquipmentEnum, IArmorEntry> ArmorProficiency { get; }

        /// <summary>
        /// Weapon Proficiency
        /// </summary>
        Dictionary<EquipmentEnum, IWeaponEntry> WeaponProficiency { get; }

        /// <summary>
        /// Tools
        /// </summary>
        Dictionary<EquipmentEnum, IEquipmentTableEntry> ToolProficiency { get; }

        /// <summary>
        /// Saving Throws
        /// </summary>
        Dictionary<AbilityEnum, IAbilityBase> SavingThrows { get; }

        /// <summary>
        /// Skills
        /// </summary>
        Dictionary<SkillEnum, ISkill> Skills { get; }

        /// <summary>
        /// The description of the class background.  Used to provide
        /// a background for the character selecting this class
        /// </summary>
        IBackgroundTableEntry? Background { get; }

        /// <summary>
        /// The level table for the class
        /// </summary>
        public IClassLevelTable? ClassLevelTable { get; }
    }
}