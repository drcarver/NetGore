using GoDungeon.Core.Enum;

namespace GoDungeon.Monsters.Interfaces
{
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

}
