namespace D20.Core.Interfaces;

/// <summary>
/// A Game Table Entry
/// </summary>
public interface IStandardTableEntry : IGameTableEntry
{
    /// <summary>
    /// The English name for the entry
    /// </summary>
    string? ProperName { get; set; }

    /// <summary>
    /// THe description of the entry
    /// </summary>
    string? Description { get; set; }
}