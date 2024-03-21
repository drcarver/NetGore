using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Ablities;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Data.Interfaces;

namespace NetGore.Core.Models;

public class Creature : DataObject, ICreature
{
    /// <summary>
    /// The creatures gender
    /// </summary>
    public Gender Gender { get; }

    /// <summary>
    /// Name of the character's race
    /// </summary>
    public string RaceName { get; set; }

    /// <summary>
    /// The Race description
    /// </summary>
    public string RaceDescription { get; set; }

    /// <summary>
    /// The race of the character
    /// </summary>
    public RaceEnum Race { get; set; }

    /// <summary>
    /// Strength measures bodily power, athletic 
    /// training, and the extent to which you can 
    /// exert raw physical force.
    /// </summary>
    public Strength Strength { get; }

    /// <summary>
    /// Intelligence measures mental acuity, accuracy 
    /// of recall, and the ability to reason.
    /// </summary>
    public Intelligence Intelligence { get; }

    /// <summary>
    /// Wisdom reflects how attuned you are to the 
    /// world around you and represents perceptiveness 
    /// and intuition.
    /// </summary>
    public Wisdom Wisdom { get; }

    /// <summary>
    /// Dexterity measures agility, reflexes, and 
    /// balance.
    /// </summary>
    public Dexterity Dexterity { get; }

    /// <summary>
    /// Constitution measures health, stamina, and 
    /// vital force.
    /// </summary>
    public Constitution Constitution { get; }

    /// <summary>
    /// Charisma measures your ability to interact 
    /// effectively with others. It includes such 
    /// factors as confidence and eloquence, and 
    /// it can represent a charming or commanding 
    /// personality.
    /// </summary>
    public Charisma Charisma { get; }

    /// <summary>
    /// THe size of the creature
    /// </summary>
    public SizeEnum Size { get; set; }

    /// <summary>
    /// The height of the creature in feet and inches
    /// </summary>
    public string Height { get; set; }

    /// <summary>
    /// The weight of the creature in pounds
    /// </summary>
    public int Weight { get; set; }

    /// <summary>
    /// The creature speed in feet
    /// </summary>
    public int Speed { get; set; }

    /// <summary>
    /// The class enum
    /// </summary>
    public List<ClassEnum> Class { get; set; } = new();

    /// <summary>
    /// THe class Names of the creature
    /// </summary>
    public List<ClassInformation> ClassInformation { get; set; } = new();

    /// <summary>
    /// Wealth in gold pieces
    /// </summary>
    public int Wealth { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Creature(ILoggerFactory loggerFactory,
        IGenderService genderService,
        IRaceService raceService)
    {
        var logger = loggerFactory.CreateLogger("Ability");
        
        // Generate the abilities
        Strength = new Strength(logger);
        Intelligence = new Intelligence(logger);
        Wisdom = new Wisdom(logger);
        Dexterity = new Dexterity(logger);
        Constitution = new Constitution(logger);
        Charisma = new Charisma(logger);

        // Generate the gender
        Gender = genderService.GetGender();

        // Set the racial traits
        raceService.SetRace(this);

        logger.LogInformation($"Strength:     {Strength.Dice}");
        logger.LogInformation($"Intelligence: {Intelligence.Dice}");
        logger.LogInformation($"Wisdom:       {Wisdom.Dice}");
        logger.LogInformation($"Dexterity:    {Dexterity.Dice}");
        logger.LogInformation($"Constitution: {Constitution.Dice}");
        logger.LogInformation($"Charisma:     {Charisma.Dice}");
    }
}