using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Ablities;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Character : BaseObject, ICharacter
{
    /// <summary>
    /// Name of the character's race
    /// </summary>
    public string? RaceName {  get; set; }

    /// <summary>
    /// The Race description
    /// </summary>
    public string? RaceDescription { get; set; }

    /// <summary>
    /// Strength measures bodily power, athletic 
    /// training, and the extent to which you can 
    /// exert raw physical force.
    /// </summary>
    public Strength Strength { get; set; } = new Strength();

    /// <summary>
    /// Intelligence measures mental acuity, accuracy 
    /// of recall, and the ability to reason.
    /// </summary>
    public Intelligence Intelligence { get; set; } = new Intelligence();

    /// <summary>
    /// Wisdom reflects how attuned you are to the 
    /// world around you and represents perceptiveness 
    /// and intuition.
    /// </summary>
    public Wisdom Wisdom { get; set; } = new Wisdom();

    /// <summary>
    /// Dexterity measures agility, reflexes, and 
    /// balance.
    /// </summary>
    public Dexterity Dexterity { get; set; } = new Dexterity();

    /// <summary>
    /// Constitution measures health, stamina, and 
    /// vital force.
    /// </summary>
    public Constitution Constitution { get; set; } = new Constitution();

    /// <summary>
    /// Charisma measures your ability to interact 
    /// effectively with others. It includes such 
    /// factors as confidence and eloquence, and 
    /// it can represent a charming or commanding 
    /// personality.
    /// </summary>
    public Charisma Charisma { get; set; } = new Charisma();

    /// <summary>
    /// Create a new Character
    /// </summary>
    [SetsRequiredMembers]
    public Character(ILoggerFactory loggerFactory)
    {
    }
}