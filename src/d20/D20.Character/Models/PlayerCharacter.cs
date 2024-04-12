using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;

using Microsoft.Extensions.Logging;

using NetGore.Core.Interfaces;

namespace D20.Character.Models;

public class PlayerCharacter : D20Character, IPlayerCharacter
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
    /// The character level
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Level Up the character
    /// </summary>
    public void LevelUp()
    {

        //switch (Level)
    }

    /// <summary>
    /// The Player Character
    /// </summary>
    /// <param name="loggerFactory">The logger service</param>
    /// <param name="raceService">Race Service</param>
    /// <param name="classService">Class service</param>
    [SetsRequiredMembers]
    public PlayerCharacter(
        ILoggerFactory loggerFactory,
        //IRaceService raceService,
        IClassService classService,
        ICharacterAdvancementTable characterAdvancement)
        : base(loggerFactory, classService)
    {
        classService.SetClass(this);
        //raceService.SetRace(this);
    }
}