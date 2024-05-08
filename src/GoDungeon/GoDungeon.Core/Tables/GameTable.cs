using System;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Threading.Tasks;

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
        /// Command to execute on a selection changed event
        /// </summary>
        /// <param name="execute">The method to execute</param>
        /// <param name="canExecute">Can the command execute</param>
        /// <returns></returns>
        public AsyncRelayCommand SelectionChangedCommand { get; set; }

        /// <summary>
        /// The method to execute when the selection changes
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        protected virtual async Task SelectionChanged()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return true if the selection can change
        /// </summary>
        /// <returns>True if selection can change</returns>
        protected virtual bool CanChangeSelection()
        {
            return false;
        }

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

        /// <summary>
        /// Constructor
        /// </summary>
        public GameTable()
        {
             SelectionChangedCommand = new AsyncRelayCommand(SelectionChanged, CanChangeSelection);
        }
    }
}
