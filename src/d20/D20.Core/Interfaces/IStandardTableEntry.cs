namespace D20.Core.Interfaces
{
    /// <summary>
    /// A Game Table Entry
    /// </summary>
    public interface IStandardTableEntry : INamedTableEntry, IBaseObject
    {
        /// <summary>
        /// The English name for the entry
        /// </summary>
        string? ProperName { get; set; }
    }
}