namespace GoDungeon.Core.Interfaces
{
    /// <summary>
    /// A Game Table Entry
    /// </summary>
    public interface IStandardTableEntry : INamedTableEntry
    {
        /// <summary>
        /// The English name for the entry
        /// </summary>
        string? ProperName { get; set; }
    }
}