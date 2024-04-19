using System.Diagnostics.CodeAnalysis;

using D20.Core.Models;
using D20.Gaming.Interfaces;

namespace D20.Gaming.Models;

public class ExperiencePointAwardEntry : GameTableEntry, IExperiencePointAwardEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ExperiencePointAwardEntry()
    {
    }

    /// <summary>
    /// Challenge Rating
    /// </summary>
    public decimal ChallengeRating { get; set; }

    /// <summary>
    /// Total XP
    /// </summary>
    public int TotalXP { get; set; }

    /// <summary>
    /// Individual XP for a party of 1-3 characters
    /// </summary>
    public int Individual1to3XP { get; set; }

    /// <summary>
    /// Individual XP for a party of 4-5 characters
    /// </summary>
    public int Individual4to5XP { get; set; }

    /// <summary>
    /// Individual XP for a party of 6+ characters
    /// </summary>
    public int Individual6PlusXP { get; set; }
}
