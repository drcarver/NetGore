using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Character : Creature, ICharacter
{
    /// <summary>
    /// The logger for the class
    /// </summary>
    private ILogger<Character>? _logger;

    /// <summary>
    /// The character class
    /// </summary>
    public ICharacterClass? CharacterClass { get; set; }

    /// <summary>
    /// The characters homeland.  Automatically generated
    /// </summary>
    public string? Homeland { get; set; }

    /// <summary>
    /// The character racial traits
    /// </summary>
    public List<RacialTraitEnum> RacialTraits { get; set; } = [];

    /// <summary>
    /// The player character parents
    /// </summary>
    public string? Parents { get; set; }

    /// <summary>
    /// The characters siblings
    /// </summary>
    public List<Creature> Siblings { get; set; } = [];

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="loggerFactory">The factory for logging messages</param>
    [SetsRequiredMembers]
    public Character(ILoggerFactory loggerFactory) :
        this()
    {
        _logger = loggerFactory.CreateLogger<Character>();
    }

    [SetsRequiredMembers]
    public Character()
    {
    }
}
