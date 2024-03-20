using Microsoft.Extensions.Logging;

using NetGore.Core.Models;
using NetGore.Data.Interfaces;

namespace NetGore.Data.Services;

public class RaceService
{
    /// <summary>
    /// The injected logger for the service. 
    /// </summary>
    private readonly ILogger<IGenderService> logger;

    //Table: Race
    private static RandomTable RaceTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 10,
                Name = "Dwarf",
                Description = "Your dwarf character has " + 
                    "an assortment of inborn abilities, " +
                    "part and parcel of dwarven nature.",
            },
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 20,
                Name = "Elf",
                Description = "Your elf character " +
                    "has a variety of natural abilities, " +
                    "the result of thousands of years " +
                    "of elven refinement.",
            },
            new RandomTableEntry
            {
                LowerRange = 21,
                UpperRange = 30,
                Name = "Halfling",
                Description = "Your halfling character " +
                    "has a number of traits in common " +
                    "with all other halflings.",
            },
            new RandomTableEntry
            {
                LowerRange = 31,
                UpperRange = 50,
                Name = "Human",
                Description = "It’s hard to make " +
                    "generalizations about humans, " +
                    "but your human character has " +
                    "these traits.",
            },
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 60,
                Name = "Dragonborn",
                Description = "Your draconic heritage " +
                    "manifests in a variety of traits " +
                    "you share with other dragonborn.",
            },
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 70,
                Name = "Gnome",
                Description = "Your gnome character " +
                    "has certain characteristics in " +
                    "common with all other gnomes.",
            },
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 80,
                Name = "Half-Elf",
                Description = "Your half‑elf character " +
                    "has some qualities in common with " +
                    "elves and some that are unique to " +
                    "half‑elves.",
            },
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 90,
                Name = "Half-Orc",
                Description = "Your half-­orc character has " +
                    "certain traits deriving from your orc " +
                    "ancestry.",
            },
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 100,
                Name = "Tiefling",
                Description = "Tieflings share certain " +
                    "racial traits as a result of their " +
                    "infernal descent",
            },
        ],
    };

    /// <summary>
    /// Get the Gender of the creature
    /// </summary>
    /// <param name="loggerFactory">The logger factory</param>
    public RaceService(ILoggerFactory loggerFactory)
    {
        logger = loggerFactory.CreateLogger<GenderService>();
    }

    /// <summary>
    /// Get the race of the creature
    /// </summary>
    /// <returns>The selected race</returns>
    private RandomTableEntry? GetRace()
    {
        var tableentry = RaceTable.GetRandomEntry();
        
        logger.LogInformation($"Got random table entry number {RaceTable.Total}, Name={tableentry?.Name}");

        return tableentry;
    }
}
