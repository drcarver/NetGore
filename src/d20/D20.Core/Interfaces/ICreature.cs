using System.Collections.Generic;

using D20.Core.Abilities;
using D20.Core.Enum;
using D20.Core.Models;

namespace D20.Core.Interfaces
{
    public interface ICreature
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
        RaceType RaceType { get; set; }

        /// <summary>
        /// Race Sub Type
        /// </summary>
        List<RaceSubTypeEnum> RaceSubType { get; set; }

        /// <summary>
        /// The languages the creature speaks
        /// </summary>
        List<LanguageEnum> Languages { get; set; }

        /// <summary>
        /// Strength measures bodily power, athletic 
        /// training, and the extent to which you can 
        /// exert raw physical force.
        /// </summary>
        Strength Strength { get; set; }

        /// <summary>
        /// Intelligence measures mental acuity, accuracy 
        /// of recall, and the ability to reason.
        /// </summary>
        Intelligence Intelligence { get; set; }

        /// <summary>
        /// Wisdom reflects how attuned you are to the 
        /// world around you and represents perceptiveness 
        /// and intuition.
        /// </summary>
        Wisdom Wisdom { get; set; }

        /// <summary>
        /// Dexterity measures agility, reflexes, and 
        /// balance.
        /// </summary>
        Dexterity Dexterity { get; set; }

        /// <summary>
        /// Constitution measures health, stamina, and 
        /// vital force.
        /// </summary>
        Constitution Constitution { get; set; }

        /// <summary>
        /// Charisma measures your ability to interact 
        /// effectively with others. It includes such 
        /// factors as confidence and eloquence, and 
        /// it can represent a charming or commanding 
        /// personality.
        /// </summary>
        Charisma Charisma { get; set; }

        /// <summary>
        /// THe size of the creature
        /// </summary>
        SizeEnum Size { get; set; }

        /// <summary>
        /// The height of the creature in feet and inches
        /// </summary>
        Height Height { get; set; }

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
        int Speed { get; set; }

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
        ArmorClass ArmorClass { get; set; }

        /// <summary>
        /// The hit points for the character
        /// </summary>
        HitPoints HitPoints { get; set; }

        /// <summary>
        /// These saves reflect your resistance to mental 
        /// influence as well as many magical effects. 
        /// Apply your Wisdom modifier to your Will saving 
        /// throws.
        /// </summary>
        WillSave WillSave { get; set; }

        /// <summary>
        /// These saves measure your ability to stand up 
        /// to physical punishment or attacks against your 
        /// vitality and health. Apply your Constitution 
        /// modifier to your Fortitude saving throws.
        /// </summary>
        FortitudeSave FortitudeSave { get; set; }

        /// <summary>
        /// These saves test your ability to dodge area 
        /// attacks and unexpected situations. Apply 
        /// your Dexterity modifier to your Reflex saving 
        /// throws
        /// </summary>
        ReflexSave ReflexSave { get; set; }

        /// <summary>
        /// The creature skills
        /// </summary>
        List<SkillEnum> Skills { get; set; }

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