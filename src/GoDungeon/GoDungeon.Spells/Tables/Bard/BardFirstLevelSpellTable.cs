using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.Spells.Enum;

namespace GoDungeon.Spells.Tables.Bard
{
    public class BardFirstLevelSpellTable : NamedTable, IBardFirstLevelSpellTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BardFirstLevelSpellTable()
        {
            Name = nameof(BardCantripSpellTable);
            ProperName = "Bard First Level Spells";
            TableType = TableTypeEnum.SpellTable;
            Description =
                "Bards have a talent for song and story, and they " +
                "come to their careers by developing this talent " +
                "as they pick up on a smattering of other skills.";
        }

        /// <summary>
        /// Initialize the game table.  This is a separate method so 
        /// we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                };
            }
        }
    }
}
