using D20.Core.Interfaces;
using D20.Gaming.Interfaces;

namespace D20.Gaming.Models;

public class ChallengeRatingEquivalenceEntry : IGameTableEntry, IChallengeRatingEquivalenceEntry
{
    /// <summary>
    /// THe number of creatures
    /// </summary>
    public int NumberOfCreatures { get; set; }

    /// <summary>
    /// Equivalent challenge rating
    /// </summary>
    public int ChallengeRatingEquivalence { get; set; }
}