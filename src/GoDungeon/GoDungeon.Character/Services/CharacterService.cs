using GoDungeon.Character.Interfaces;
using GoDungeon.Character.Models;

using GoDungeon.Character.Interfaces;

using Microsoft.Extensions.Logging;
using GoDungeon.Character.Services;

namespace NetGore.Data.Services;

public class CharacterService : ICharacterService
{
    /// <summary>
    /// The logger for this class
    /// </summary>
    private ILogger Logger { get; }

    /// <summary>
    /// The class service
    /// </summary>
    public IClassService ClassService { get; }

    /// <summary>
    /// The logger factory
    /// </summary>
    private ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Generate a new character
    /// </summary>
    /// <returns>The character created</returns>
    public ICharacter CreateCharacter()
    {
        return new D20Character(LoggerFactory);
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="loggerFactory">The logger factory</param>
    public CharacterService(ILoggerFactory loggerFactory,
        IClassService classService)
    {
        LoggerFactory = loggerFactory;
        Logger = loggerFactory.CreateLogger<ClassService>();
        ClassService = classService;
    }
}
