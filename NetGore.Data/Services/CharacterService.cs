using Microsoft.Extensions.Logging;

using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Services;

public class CharacterService : ICharacterService
{
    /// <summary>
    /// The logger for this class
    /// </summary>
    private ILogger Logger { get; }

    /// <summary>
    /// The logger factory
    /// </summary>
    private ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Generate a new character
    /// </summary>
    /// <returns>The character created</returns>
    public Character CreateCharacter()
    {
        return new Character(LoggerFactory);
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="loggerFactory">The logger factory</param>
    public CharacterService(ILoggerFactory loggerFactory)
    {
        LoggerFactory = loggerFactory;
        Logger = loggerFactory.CreateLogger<ClassService>();
    }
}
