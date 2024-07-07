using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Interfaces
{
    public interface ICreature : IStandardTableEntry
    {
        ///// <summary>
        /// The creatures gender
        /// </summary>
        GenderEnum Gender { get; set; }

        /// <summary>
        /// The character's race
        /// </summary>
        RaceEnum Race { get; set; }

        /// <summary>
        /// Race Type
        /// </summary>
        RaceTypeEnum RaceType { get; set; }

        /// <summary>
        /// Race Sub Type
        /// </summary>
        ObservableCollection<RaceSubTypeEnum> RaceSubType { get; set; }

        /// <summary>
        /// The languages the creature speaks
        /// </summary>
        ObservableCollection<LanguageEnum> Languages { get; set; }

        /// <summary>
        /// Strength measures bodily power, athletic 
        /// training, and the extent to which you can 
        /// exert raw physical force.
        /// </summary>
        IAbilityBase Strength { get; set; }

        /// <summary>
        /// Intelligence measures mental acuity, accuracy 
        /// of recall, and the ability to reason.
        /// </summary>
        IAbilityBase Intelligence { get; set; }

        /// <summary>
        /// Wisdom reflects how attuned you are to the 
        /// world around you and represents perceptiveness 
        /// and intuition.
        /// </summary>
        IAbilityBase Wisdom { get; set; }

        /// <summary>
        /// Dexterity measures agility, reflexes, and 
        /// balance.
        /// </summary>
        IAbilityBase Dexterity { get; set; }

        /// <summary>
        /// Constitution measures health, stamina, and 
        /// vital force.
        /// </summary>
        IAbilityBase Constitution { get; set; }

        /// <summary>
        /// Charisma measures your ability to interact 
        /// effectively with others. It includes such 
        /// factors as confidence and eloquence, and 
        /// it can represent a charming or commanding 
        /// personality.
        /// </summary>
        IAbilityBase Charisma { get; set; }

        /// <summary>
        /// THe size of the creature
        /// </summary>
        SizeEnum Size { get; set; }

        /// <summary>
        /// The height of the creature in feet and inches
        /// </summary>
        IHeight Height { get; set; }

        /// <summary>
        /// The weight of the creature in pounds
        /// </summary>
        int Weight { get; set; }

        /// <summary>
        /// The age of the creature
        /// </summary>
        int Age { get; set; }

        /// <summary>
        /// The creature speed in feet
        /// </summary>
        ObservableCollection<MovementViewModel> Speed { get; set; }

        /// <summary>
        /// Wealth in gold pieces
        /// </summary>
        int Wealth { get; set; }

        /// <summary>
        /// Creature alignment
        /// </summary>
        AlignmentEnum Alignment { get; set; }

        /// <summary>
        /// The base armor class of the creature
        /// </summary>
        IArmorClass ArmorClass { get; set; }

        /// <summary>
        /// The hit points for the character
        /// </summary>
        IHitPoints HitPoints { get; set; }

        /// <summary>
        /// These saves reflect your resistance to mental 
        /// influence as well as many magical effects. 
        /// Apply your Wisdom modifier to your Will saving 
        /// throws.
        /// </summary>
        ISavingThrow WillSave { get; set; }

        /// <summary>
        /// These saves measure your ability to stand up 
        /// to physical punishment or attacks against your 
        /// vitality and health. Apply your Constitution 
        /// modifier to your Fortitude saving throws.
        /// </summary>
        ISavingThrow FortitudeSave { get; set; }

        /// <summary>
        /// These saves test your ability to dodge area 
        /// attacks and unexpected situations. Apply 
        /// your Dexterity modifier to your Reflex saving 
        /// throws
        /// </summary>
        ISavingThrow ReflexSave { get; set; }

        /// <summary>
        /// The creature skills
        /// </summary>
        ObservableCollection<SkillEnum> Skills { get; set; }

        /// <summary>
        /// The challenge rating of the creature
        /// </summary>
        decimal ChallengeRating { get; set; }

        /// <summary>
        /// THe experience points for killing the creature
        /// </summary>
        int ExperiencePoints { get; set; }
    }
}