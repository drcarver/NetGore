using System.Diagnostics.CodeAnalysis;

using D20.Core.Abilities;
using D20.Core.Base;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Tables;

namespace D20.Core.Models;

public class Creature : DataObject, ICreature
{
    ///// <summary>
    /// The creatures gender
    /// </summary>
    public GenderEnum Gender { get; set; }

    /// <summary>
    /// The character's race
    /// </summary>
    public RaceEnum Race { get; set; }

    /// <summary>
    /// Race Type
    /// </summary>
    public RaceType RaceType { get; set; }

    /// <summary>
    /// Race Sub Type
    /// </summary>
    public List<RaceSubTypeEnum> RaceSubType { get; set; } = [];

    /// <summary>
    /// The languages the creature speaks
    /// </summary>
    public List<LanguageEnum> Languages { get; set; } = [];

    /// <summary>
    /// Strength measures bodily power, athletic 
    /// training, and the extent to which you can 
    /// exert raw physical force.
    /// </summary>
    public Strength Strength { get; set; }

    /// <summary>
    /// Intelligence measures mental acuity, accuracy 
    /// of recall, and the ability to reason.
    /// </summary>
    public Intelligence Intelligence { get; set; }

    /// <summary>
    /// Wisdom reflects how attuned you are to the 
    /// world around you and represents perceptiveness 
    /// and intuition.
    /// </summary>
    public Wisdom Wisdom { get; set; }

    /// <summary>
    /// Dexterity measures agility, reflexes, and 
    /// balance.
    /// </summary>
    public Dexterity Dexterity { get; set; }

    /// <summary>
    /// Constitution measures health, stamina, and 
    /// vital force.
    /// </summary>
    public Constitution Constitution { get; set; }

    /// <summary>
    /// Charisma measures your ability to interact 
    /// effectively with others. It includes such 
    /// factors as confidence and eloquence, and 
    /// it can represent a charming or commanding 
    /// personality.
    /// </summary>
    public Charisma Charisma { get; set; }

    /// <summary>
    /// THe size of the creature
    /// </summary>
    public SizeEnum Size { get; set; }

    /// <summary>
    /// The height of the creature in feet and inches
    /// </summary>
    public Height Height { get; set; }

    /// <summary>
    /// The weight of the creature in pounds
    /// </summary>
    public int Weight { get; set; }

    /// <summary>
    /// The age of the creature
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// The creature speed in feet
    /// </summary>
    public int Speed { get; set; }

    /// <summary>
    /// Wealth in gold pieces
    /// </summary>
    public int Wealth { get; set; }

    /// <summary>
    /// Creature alignment
    /// </summary>
    public AlignmentEnum Alignment { get; set; } = AlignmentEnum.NonAligned;

    /// <summary>
    /// The base armor class of the creature
    /// </summary>
    public ArmorClass ArmorClass { get; set; } = new ArmorClass();

    /// <summary>
    /// The hit points for the character
    /// </summary>
    public HitPoints HitPoints { get; set; }

    /// <summary>
    /// These saves reflect your resistance to mental 
    /// influence as well as many magical effects. 
    /// Apply your Wisdom modifier to your Will saving 
    /// throws.
    /// </summary>
    public WillSave WillSave { get; set; }

    /// <summary>
    /// These saves measure your ability to stand up 
    /// to physical punishment or attacks against your 
    /// vitality and health. Apply your Constitution 
    /// modifier to your Fortitude saving throws.
    /// </summary>
    public FortitudeSave FortitudeSave { get; set; }

    /// <summary>
    /// These saves test your ability to dodge area 
    /// attacks and unexpected situations. Apply 
    /// your Dexterity modifier to your Reflex saving 
    /// throws
    /// </summary>
    public ReflexSave ReflexSave { get; set; }

    /// <summary>
    /// The creature skills
    /// </summary>
    public List<SkillEnum> Skills { get; set; }

    /// <summary>
    /// The challenge rating of the creature
    /// </summary>
    public decimal ChallengeRating { get; set; }

    /// <summary>
    /// THe experience points for killing the creature
    /// </summary>
    public int ExperiencePoints { get; set; }

    /// <summary>
    /// Creatures that have a height and weight implement
    /// this partial method
    /// </summary>
    public virtual void SetHeightAndWeight()
    {
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Creature()
    {
        // Generate the abilities
        Strength = new Strength(this);
        Intelligence = new Intelligence(this);
        Wisdom = new Wisdom(this);
        Dexterity = new Dexterity(this);
        Constitution = new Constitution(this);
        Charisma = new Charisma(this);

        // Generate the gender
        Gender = new GenderTable().GetGender();
        SetHeightAndWeight();

        // Saving throws
        WillSave = new WillSave(this);
        FortitudeSave = new FortitudeSave(this);
        ReflexSave = new ReflexSave(this);
    }
}