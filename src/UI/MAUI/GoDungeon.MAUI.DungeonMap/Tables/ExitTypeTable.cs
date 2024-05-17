using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.Tables;

public class ExitTypeTable : RandomTable, IExitTypeTable
{
    public ExitTypeTable()
    {
        Name = nameof(ExitTypeTable);
        ProperName = "Exit Type Table";
        TableType = TableTypeEnum.RandomDungeonTable;
        DiceSides = 20;
        Description =
            "The chamber exit type table";
    }

    //EXIT TYPE
    //d20 Type
    //1-10 Door (roll on the Door Type table)
    //11-20 Corridor, 10ft. long
    /// <summary>
    /// Initialize the game table.  This is a separate method so we 
    /// can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of 
    /// optimization to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        if (Table == null || Table.Count == 0)
        {
            Table = new ObservableCollection<IGameTableEntry>
            {
                #region 1-10 Door (roll on the Door Type table)
                //1-10 Door (roll on the Door Type table)
                new RandomTableEntryViewModel
                {
                    Range = new Range(01, 10),
                    Name = nameof(ExitTypeEnum.Door),
                    ProperName = "Door",
                    Description = "Door (roll on the Door Type table)",
                },
                #endregion

                #region 11-20 Corridor, 10ft. long
                //11-20 Corridor, 10ft. long
                new RandomTableEntryViewModel
                {
                    Range = new Range(11, 20),
                    Name = nameof(ExitTypeEnum.Corridor),
                    ProperName = "Corridor, 10ft. long",
                    Description = "Corridor, 10ft. long",
                },
                #endregion
            };
        }
    }
}

