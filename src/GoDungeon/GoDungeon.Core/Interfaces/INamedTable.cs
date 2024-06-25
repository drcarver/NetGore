namespace GoDungeon.Core.Interfaces
{
    /// <summary>
    /// The interface for the table
    /// </summary>
    public interface INamedTable : IGameTable
    {
        /// <summary>
        /// Get a entry from the table by it's name
        /// </summary>
        /// <returns>The selected INamedTableEntry.</returns>
        INamedTableEntry GetEntryByName(string Name);
    }
}