using D20.Character.Interfaces;
using D20.Character.Race;
using D20.Core.Enum;
using D20.Core.Models;

using Microsoft.Extensions.Logging;

using NetGore.Data.Race;

namespace D20.Character.Services;

public class RaceService : IRaceService
{
    /// <summary>
    /// The logger for the service. 
    /// </summary>
    private readonly ILogger Logger;

    /// <summary>
    /// The injected logger factory for the service. 
    /// </summary>
    private readonly ILoggerFactory LoggerFactory;

    //Table: Race
    public static GameTable RaceTable { get; set; } = new()
    {
        Table =
        [
            new StandardTableEntry
            {
                Name = nameof(Dwarf),
            },
            new StandardTableEntry
            {
                Name = nameof(Elf),
            },
            new StandardTableEntry
            {
                Name = nameof(Halfling),
            },
            new StandardTableEntry
            {
                Name = nameof(Human),
            },
            new StandardTableEntry
            {
                Name = nameof(Dragonborn),
            },
            new StandardTableEntry
            {
                Name = nameof(Gnome),
            },
            new StandardTableEntry
            {
                Name = nameof(HalfElf),
            },
            new StandardTableEntry
            {
                Name = nameof(HalfOrc),
            },
            new StandardTableEntry
            {
                Name = nameof(Tiefling),
            },
        ],
    };

    /// <summary>
    /// Get the race of the creature
    /// </summary>
    /// <param name="loggerFactory">The logger factory</param>
    public RaceService(ILoggerFactory loggerFactory)
    {
        Logger = loggerFactory.CreateLogger<RaceService>();
    }

    /// <summary>
    /// Get the race of the creature
    /// </summary>
    public void SetRace(ICharacter creature)
    {
        var tableentry = RaceTable.GetRandomEntry();

        Logger.LogInformation($"Got random table entry Name={tableentry?.Name}");

        //switch (tableentry?.Name)
        //{
        //    case nameof(Dragonborn):
        //        creature.Race = RaceEnum.Dragonborn;
        //        var dragonborn = new Dragonborn(creature);
        //        break;
        //    case nameof(Dwarf):
        //        creature.Race = RaceEnum.Dwarf;
        //        var dwarf = new Dwarf(creature);
        //        dwarf.GenerateRaceBackground(creature);
        //        break;
        //    case nameof(Elf):
        //        creature.Race = RaceEnum.Elf;
        //        var elf = new Elf(creature);
        //        elf.GenerateRaceBackground(creature);
        //        break;
        //    case nameof(Gnome):
        //        creature.Race = RaceEnum.Gnome;
        //        var gnome = new Gnome(creature);
        //        gnome.GenerateRaceBackground(creature);
        //        break;
        //    case nameof(HalfElf):
        //        creature.Race = RaceEnum.HalfElf;
        //        var halfelf = new HalfElf(creature);
        //        break;
        //    case nameof(Halfling):
        //        creature.Race = RaceEnum.Halfling;
        //        var halfling = new Halfling(creature);
        //        break;
        //    case nameof(HalfOrc):
        //        creature.Race = RaceEnum.HalfOrc;
        //        var halforc = new HalfOrc(creature);
        //        break;
        //    case nameof(Human):
        //        creature.Race = RaceEnum.Human;
        //        var human = new Human(creature);
        //        break;
        //    case nameof(Tiefling):
        //        creature.Race = RaceEnum.Tiefling;
        //        var tiefling = new Tiefling(creature);
        //        break;
        //}
    }
}
