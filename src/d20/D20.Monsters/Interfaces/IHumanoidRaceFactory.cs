using D20.Core.Enum;

namespace D20.Monsters.Interfaces;

public interface IHumanoidRaceFactory
{
    /// <summary>
    /// Create a humanoid Race of type race
    /// </summary>
    /// <param name="race">The race to create</param>
    /// <returns>A humanoid race of the proper type</returns>
    IHumanoidRace Create(RaceEnum race);

    /// <summary>
    /// Create a random humanoid race using the race table
    /// </summary>
    /// <returns></returns>
    IHumanoidRace? CreateRandom();
}

