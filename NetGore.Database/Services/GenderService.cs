using Microsoft.Extensions.Logging;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Database.Interfaces;

namespace NetGore.Database.Services;

public class GenderService : IGenderService
{
    /// <summary>
    /// The injected logger for the service. 
    /// </summary>
    private readonly ILogger<IGenderService> logger;

    //Table: Gender
    //d%	 Result
    //01–50	 Male
    //51–100 Female
    private static RandomTable GenderTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 50,
                Name = "Male",
            },
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 100,
                Name = "Female",
            },
        ],
    };

    /// <summary>
    /// Get the Gender of the creature
    /// </summary>
    /// <param name="loggerFactory">The logger factory</param>
    public GenderService(ILoggerFactory loggerFactory)
    {
        logger = loggerFactory.CreateLogger<GenderService>();
    }

    /// <summary>
    /// Get the Gender of the creature
    /// </summary>
    /// <returns>The selected Gender</returns>
    public Gender? GetGender()
    {
        if (GenderTable == null)
        {
            return null;
        }

        var tableentry = GenderTable.GetRandomEntry();
        logger.LogTrace($"Got the random table entry number {GenderTable.Total}, Name={tableentry.Name}");

        return new Gender
        {
            Name = tableentry?.Name,
            GenderEnum = tableentry?.Name == "Male" ?
                GenderEnum.Male :
                GenderEnum.Female,
        };
    }
}