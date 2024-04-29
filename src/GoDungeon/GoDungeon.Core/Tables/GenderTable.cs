using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Tables
{
    /// <summary>
    /// The gender table.  
    /// </summary>
    public class GenderTable : NamedTable, IGenderTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GenderTable()
        {
            Name = nameof(GenderTable);
            ProperName = "Gender Table";
            TableType = TableTypeEnum.CoreTable;
        }

        /// <summary>
        /// Get the Gender of the creature
        /// </summary>
        /// <returns>The selected Gender</returns>
        public GenderEnum GetGender()
        {
            InitializeTable();
            var entry = (INamedTableEntry?)GetRandomEntry();
            if (entry != null)
            switch (entry.Name)
            {
                case nameof(GenderEnum.Male):
                    return GenderEnum.Male;
                case nameof(GenderEnum.Female):
                    return GenderEnum.Female;

            }
            return GenderEnum.Male;
        }

        /// <summary>
        /// Initialize the game table.  This is a separate method 
        /// so we can create a game table for it;s meta properties
        /// with out creating the table.  A bit of optimization to 
        /// conserve memory
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    new NamedTableEntryViewModel
                    {
                        Name = nameof(GenderEnum.Male),
                        Description = "The Male of the species",
                    },

                    new NamedTableEntryViewModel
                    {
                        Name = nameof(GenderEnum.Female),
                        Description = "The Female of the species",
                    },
                };
            }
        }
    }
}