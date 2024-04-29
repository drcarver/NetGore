using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
{
    public interface IClassPrerequisite
    {
        /// <summary>
        /// The Abbreviation for the ability
        /// </summary>
        AbilityEnum Ability { get; set; }

        /// <summary>
        /// The ability score
        /// </summary>
        int Score { get; set; }

        /// <summary>
        /// Does the ability have a high enough score?
        /// </summary>
        /// <param name="creature">The creature to test</param>
        /// <returns>True if the ability is high enough</returns>
        bool AbilityAcceptable(ICreature creature);
    }
}