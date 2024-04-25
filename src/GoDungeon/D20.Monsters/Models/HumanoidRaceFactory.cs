using D20.Core.Enum;
using D20.Monsters.Interfaces;
using D20.Monsters.Models.Humanoid;
using D20.Monsters.Race;

namespace D20.Monsters.Models;

public class HumanoidRaceFactory : IHumanoidRaceFactory
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="raceTable">The able of humanoid races</param>
    public HumanoidRaceFactory(
        IHumanoidRaceTable raceTable,
        IServiceProvider services)
    {
        RaceTable = raceTable;
        Services = services;
    }

    /// <summary>
    /// The humanoid race table
    /// </summary>
    private IHumanoidRaceTable RaceTable { get; }

    /// <summary>
    /// THe service provider
    /// </summary>
    private IServiceProvider Services { get; }

    /// <summary>
    /// Create a humanoid of the proper race
    /// </summary>
    /// <param name="race">The humanoid race to create</param>
    /// <returns>The new humanoid race object</returns>
    public IHumanoidRace Create(RaceEnum race)
    {
        return GetHumanoidRace(race);
    }

    /// <summary>
    /// Create a random humanoid race using the race table
    /// </summary>
    /// <returns></returns>
    public IHumanoidRace? CreateRandom()
    {
        RaceTable.InitializeTable();
        IRaceTableEntry? raceTableEntry = (IRaceTableEntry?)RaceTable.GetRandomRangeEntry();
        if (raceTableEntry != null)
        {
            return GetHumanoidRace(raceTableEntry.Race);
        }
        return null;
    }

    /// <summary>
    /// The humanoid Race's
    /// </summary>
    /// <returns>The humanoid race created</returns>
    private IHumanoidRace? GetHumanoidRace(RaceEnum race)
    {
        switch (race)
        {
            case RaceEnum.Halfling:
                return Services?.GetService<IHalfling>();
            default:
                return new HumanoidRace() { Race = race };
        }
    }
}
