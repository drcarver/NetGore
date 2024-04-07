namespace NetGore.Core.Interfaces;

/// <summary>
/// A Game Table Entry
/// </summary>
public interface IGameTableEntry : IBaseObject
{
    /// <summary>
    /// The range for the item in the table.  Used
    /// to access by number or through a random dice
    /// roll
    /// </summary>
    Range Range { get; set; }

    /// <summary>
    /// The English name for the entry
    /// </summary>
    string? ProperName { get; set; }
}