using System.Collections.ObjectModel;
using System.Security.Cryptography;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Tables
{
    /// <summary>
    /// A table of items.  This is usually a list of
    /// objects each with a particular range (e.g. 01-20).
    /// The table provides methods to get to items in it
    /// by name, number or randomly.
    /// </summary>
    public partial class GameTable : BaseObjectViewModel, IGameTable
    {
        /// <summary>
        /// The proper name of the table
        /// </summary>
        [ObservableProperty]
        private string? properName = string.Empty;

        /// <summary>
        /// The table type
        /// </summary>
        [ObservableProperty]
        private TableTypeEnum tableType;

        /// <summary>
        /// The table itself
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<IGameTableEntry>? table;

        /// <summary>
        /// The selected table entry
        /// </summary>
        [ObservableProperty]
        private IGameTableEntry? selectedItem;
        
        /// <summary>
        /// Get a random entry from the table 
        /// </summary>
        /// <returns>The selected TableEntry.</returns>
        public IGameTableEntry? GetRandomEntry()
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                return Table?[RandomNumberGenerator.GetInt32(Table.Count)];
            }
        }

        /// <summary>
        /// Initialize the game table.  This is a separate method so 
        /// we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// initialize to conserve memory on big tables
        /// </summary>
        public virtual void InitializeTable()
        {
        }
    }
}
