using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Interfaces;
using NetGore.Data.Interfaces;

namespace NetGore.Core.Models;

public class PlayerCharacter : Character, IPlayerCharacter
{
    /// <summary>
    /// The account for the player who owns this
    /// character
    /// </summary>
    public IAccount? Account { get; set; }

    /// <summary>
    /// The experience points for the player character
    /// </summary>
    public int ExperiencePoints { get; set; }

    /// <summary>
    /// The classes for this player character
    /// </summary>
    public List<IClassInformation> ClassInformation { get; }

    /// <summary>
    /// The Player Character
    /// </summary>
    /// <param name="loggerFactory">The logger service</param>
    /// <param name="raceService">Race Service</param>
    /// <param name="classService">Class service</param>
    [SetsRequiredMembers]
    public PlayerCharacter(
        ILoggerFactory loggerFactory,
        IRaceService raceService,
        IClassService classService)
        : base(loggerFactory, classService)
    {
        classService.SetClass(this);
        raceService.SetRace(this);
    }
}