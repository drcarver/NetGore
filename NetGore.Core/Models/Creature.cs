using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Ablities;
using NetGore.Core.Base;
using NetGore.Core.Data;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Creature : DataObject, ICreature
{
    /// <summary>
    /// The logger for this class
    /// </summary>
    private readonly ILogger? _logger;

    /// <summary>
    /// The creatures gender
    /// </summary>
    public Gender? Gender { get; }

    /// <summary>
    /// Name of the character's race
    /// </summary>
    public string? RaceName { get; set; }

    /// <summary>
    /// The Race description
    /// </summary>
    public string? RaceDescription { get; set; }

    /// <summary>
    /// The race of the character
    /// </summary>
    public RaceEnum Race { get; set; }

    /// <summary>
    /// Race Type
    /// </summary>
    public RaceType RaceType { get; set; }

    /// <summary>
    /// Race Sub Type
    /// </summary>
    public List<RaceSubType> RaceSubType { get; set; } = [];

    /// <summary>
    /// The languages the creature speaks
    /// </summary>
    public List<LanguageEnum> Languages { get; set; } = [];

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
    public string? Height { get; set; }

    /// <summary>
    /// The weight of the creature in pounds
    /// </summary>
    public int Weight { get; set; }

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
    public AlignmentEnum Alignment { get; set; } = AlignmentEnum.Any;
    
    /// <summary>
    /// The age of the creature
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="loggerFactory">The factory for logging messages</param>
    [SetsRequiredMembers]
    public Creature(ILoggerFactory loggerFactory) :
        this()
    {
        _logger = loggerFactory.CreateLogger<Creature>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Creature()
    {
        // Generate the abilities
        Strength = new Strength(_logger);
        Intelligence = new Intelligence(_logger);
        Wisdom = new Wisdom(_logger);
        Dexterity = new Dexterity(_logger);
        Constitution = new Constitution(_logger);
        Charisma = new Charisma(_logger);

        // Generate the gender
        Gender = GenderData.GetGender();

        // log the creature info
        _logger?.LogInformation($"Strength:     {Strength.Dice}");
        _logger?.LogInformation($"Intelligence: {Intelligence.Dice}");
        _logger?.LogInformation($"Wisdom:       {Wisdom.Dice}");
        _logger?.LogInformation($"Dexterity:    {Dexterity.Dice}");
        _logger?.LogInformation($"Constitution: {Constitution.Dice}");
        _logger?.LogInformation($"Charisma:     {Charisma.Dice}");
    }
}