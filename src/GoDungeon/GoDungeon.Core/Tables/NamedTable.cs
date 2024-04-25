using System.Linq;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.Tables
{
    /// <summary>
    /// A table of items.  This is usually a list of
    /// objects each with a particular range (e.g. 01-20).
    /// The table provides methods to get to items in it
    /// by name, number or randomly.
    /// </summary>
    public class NamedTable : GameTable, INamedTable
    {
        /// <summary>
        /// Get a entry from the table by it's name
        /// </summary>
        /// <returns>The selected RandomTableEntry.</returns>
        public INamedTableEntry GetEntryByName(string Name)
        {
            var te = Table.Cast<INamedTableEntry>().First(t => t.Name == Name);
            return te;
        }
    }
}
