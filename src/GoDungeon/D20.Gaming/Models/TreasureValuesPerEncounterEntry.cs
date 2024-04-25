using D20.Core.Interfaces;
using D20.Gaming.Interfaces;

namespace D20.Gaming.Models;

/// <summary>
/// The speed of the campaign’s XP progression (slow, medium, 
/// or fast).
/// </summary>
public class TreasureValuesPerEncounterEntry : ITreasureValuesPerEncounterEntry
{
    /// <summary>
    /// The challenge rating
    /// </summary>
    public decimal ChallengeRating { get; set; }

    /// <summary>
    /// The gold pieces awarded for encounter when playing
    /// a campaign with a slow XP progression
    /// </summary>
    public int Slow { get; set; }

    /// <summary>
    /// The gold pieces awarded for encounter when playing
    /// a campaign with a medium XP progression
    /// </summary>
    public int Medium { get; set; }

    /// <summary>
    /// The gold pieces awarded for encounter when playing
    /// a campaign with a fast XP progression
    /// </summary>
    public int Fast { get; set; }
}