using D20.Core.Enum;
using D20.Core.Models;

namespace D20.Character.Interfaces;

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
    bool AbilityAcceptable(Creature creature);
}