using D20.Core.Interfaces;

namespace D20.Gaming.Interfaces;

public interface ITreasureValuesPerEncounterEntry : IGameTableEntry
{
    /// <summary>
    /// The challenge rating
    /// </summary>
    decimal ChallengeRating { get; set; }

    /// <summary>
    /// The gold pieces awarded for encounter when playing
    /// a campaign with a slow XP progression
    /// </summary>
    int Slow { get; set; }

    /// <summary>
    /// The gold pieces awarded for encounter when playing
    /// a campaign with a medium XP progression
    /// </summary>
    int Medium { get; set; }

    /// <summary>
    /// The gold pieces awarded for encounter when playing
    /// a campaign with a fast XP progression
    /// </summary>
    int Fast { get; set; }

}