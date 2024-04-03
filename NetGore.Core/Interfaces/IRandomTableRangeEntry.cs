using NetGore.Core.Enum;

namespace NetGore.Core.Interfaces;

public interface IRandomTableRangeEntry
{
    /// <summary>
    /// The table to call for more data
    /// </summary>
    string? AlternateTable { get; set; }

    /// <summary>
    /// The class for this entry
    /// </summary>
    ClassEnum Class { get; set; }

    /// <summary>
    /// Conflict points for this entry
    /// </summary>
    int ConflictPoints { get; set; }

    /// <summary>
    /// The proper name for this entry
    /// </summary>
    string? ProperName { get; set; }

    /// <summary>
    /// The range for the dice roll for this entry
    /// </summary>
    Range Range { get; set; }

    /// <summary>
    /// The traits for this entry
    /// </summary>
    List<TraitEnum> Traits { get; set; }
}