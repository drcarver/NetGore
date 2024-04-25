namespace GoDungeon.Core.Interfaces
{
    /// <summary>
    /// A Game Table Entry
    /// </summary>
    public interface IStandardTableEntryViewModel : INamedTableEntry
    {
        /// <summary>
        /// The English name for the entry
        /// </summary>
        string? ProperName { get; set; }
    }
}