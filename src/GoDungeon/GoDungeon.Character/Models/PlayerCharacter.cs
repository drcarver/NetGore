using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;

using GoDungeon.Character.Interfaces;

using Microsoft.Extensions.Logging;

namespace D20.Character.Models;

public class PlayerCharacter : D20Character, ICharacter
{
    /// <summary>
    /// The account for the player who owns this
    /// character
    /// </summary>
    //public IAccount? Account { get; set; }

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
        : base(loggerFactory)
    {
        classService.SetClass(this);
        //raceService.SetRace(this);
    }
}