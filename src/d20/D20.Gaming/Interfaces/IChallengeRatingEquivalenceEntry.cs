namespace D20.Gaming.Interfaces;

public interface IChallengeRatingEquivalenceEntry
{
    /// <summary>
    /// THe number of creatures
    /// </summary>
    int NumberOfCreatures { get; set; }

    /// <summary>
    /// Equivalent challenge rating
    /// </summary>
    int ChallengeRatingEquivalence { get; set; }
}