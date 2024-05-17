using System;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.MAUI.DungeonMap.Interfaces;
using GoDungeon.MAUI.DungeonMap.ViewModels;

namespace GoDungeon.MAUI.DungeonMap.Tables;

public class ChamberExitTable : RandomTable, IChamberExitTable
{
    /// <summary>
    /// Whenever a roll on a table indicates a chamber, use the Chamber 
    /// table to define its dimensions.Then roll on the Chamber Exits 
    /// table to determine the number of exits.For each exit, roll on 
    /// the Exit Location and Exit Type tables to determine the
    /// nature and placement of the exit.
    /// </summary>
    public ChamberExitTable()
    {
        Name = nameof(ChamberTable);
        ProperName = "ChamberExitTable";
        TableType = TableTypeEnum.RandomDungeonTable;
        DiceSides = 20;
        Description =
            "The dungeon chambers exits";
    }

    //CHAMBER EXITS
    //d20 Normal Chamber Large Chamber 
    //1-3         0           0
    //4-5         0           1
    //6-8         1           1
    //9-11        1           2
    //12-13       2           2
    //14-15       2           3
    //16-17       3           3
    //18          3           4
    //19          4           5
    //20          4           6
    //¹ Use the Normal Chamber column on the Chamber Exits table.
    //² Use the Large Chamber column on the Chamber Exits table.
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
                #region 1-3         0           0
                //1-3         0           0
                new ChamberExitTableEntryViewModel
                {
                    Range = new Range(01, 03),
                    Name = nameof(ChamberExitEnum.NoExit),
                    ProperName = nameof(ChamberExitEnum.NoExit),
                    Description = nameof(ChamberExitEnum.NoExit),
                    LargeChamber = 0,
                    NormalChamber = 0,
                },
                #endregion

                #region 4-5         0           1
                //4-5         0           1
                new ChamberExitTableEntryViewModel
                {
                    Range = new Range(04, 05),
                    Name = nameof(ChamberExitEnum.Exits01),
                    ProperName = nameof(ChamberExitEnum.Exits01),
                    Description = nameof(ChamberExitEnum.Exits01),
                    LargeChamber = 1,
                    NormalChamber = 0,
                },
                #endregion

                #region 6-8         1           1
                //6-8         1           1
                new ChamberExitTableEntryViewModel
                {
                    Range = new Range(06, 08),
                    Name = nameof(ChamberExitEnum.Exits11),
                    ProperName = nameof(ChamberExitEnum.Exits11),
                    Description = nameof(ChamberExitEnum.Exits11),
                    LargeChamber = 1,
                    NormalChamber = 1,
                },
                #endregion

                #region 9-11        1           2
                //9-11        1           2
                new ChamberExitTableEntryViewModel
                {
                    Range = new Range(09, 11),
                    Name = nameof(ChamberExitEnum.Exits12),
                    ProperName = nameof(ChamberExitEnum.Exits12),
                    Description = nameof(ChamberExitEnum.Exits12),
                    LargeChamber = 2,
                    NormalChamber = 1,
                },
                #endregion

                #region 12-13       2           2
                //12-13       2           2
                new ChamberExitTableEntryViewModel
                {
                    Range = new Range(12, 13),
                    Name = nameof(ChamberExitEnum.Exits22),
                    ProperName = nameof(ChamberExitEnum.Exits22),
                    Description = nameof(ChamberExitEnum.Exits22),
                    LargeChamber = 2,
                    NormalChamber = 2,
                },
                #endregion

                #region 14-15       2           3
                //14-15       2           3
                new ChamberExitTableEntryViewModel
                {
                    Range = new Range(14, 15),
                    Name = nameof(ChamberExitEnum.Exits23),
                    ProperName = nameof(ChamberExitEnum.Exits23),
                    Description = nameof(ChamberExitEnum.Exits23),
                    LargeChamber = 3,
                    NormalChamber = 2,
                },
                #endregion

                #region 16-17       3           3
                //16-17       3           3
                new ChamberExitTableEntryViewModel
                {
                    Range = new Range(16, 17),
                    Name = nameof(ChamberExitEnum.Exits33),
                    ProperName = nameof(ChamberExitEnum.Exits33),
                    Description = nameof(ChamberExitEnum.Exits33),
                    LargeChamber = 3,
                    NormalChamber = 3,
                },
                #endregion

                #region 18          3           4
                //18          3           4
                new ChamberExitTableEntryViewModel
                {
                    Range = new Range(18, 18),
                    Name = nameof(ChamberExitEnum.Exits34),
                    ProperName = nameof(ChamberExitEnum.Exits34),
                    Description = nameof(ChamberExitEnum.Exits34),
                    LargeChamber = 4,
                    NormalChamber = 3,
                },
                #endregion

                #region 19          4           5
                //19          4           5
                new ChamberExitTableEntryViewModel
                {
                    Range = new Range(19, 19),
                    Name = nameof(ChamberExitEnum.Exits45),
                    ProperName = nameof(ChamberExitEnum.Exits45),
                    Description = nameof(ChamberExitEnum.Exits45),
                    LargeChamber = 5,
                    NormalChamber = 4,
                },
                #endregion

                #region 20          4           6
                //20          4           6
                new ChamberExitTableEntryViewModel
                {
                    Range = new Range(20, 20),
                    Name = nameof(ChamberExitEnum.Exits46),
                    ProperName = nameof(ChamberExitEnum.Exits46),
                    Description = nameof(ChamberExitEnum.Exits46),
                    LargeChamber = 6,
                    NormalChamber = 4,
                },
                #endregion
            };
        }
    }
}

