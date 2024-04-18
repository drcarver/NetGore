using System.Diagnostics.CodeAnalysis;

using D20.Core.Models;
using D20.Gaming.Interfaces;

namespace D20.Gaming.Models;

public class EncounterDesignEntry : GameTableEntry, IEncounterDesignEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public EncounterDesignEntry()
    {
    }

    /// <summary>
    /// Challenge Rating Equals
    /// </summary>
    public int ChallengeRatingEquals { get; set; }
}
