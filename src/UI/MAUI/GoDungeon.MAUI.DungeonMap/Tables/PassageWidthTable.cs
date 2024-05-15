using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.Tables;

/// <summary>
/// When generating passages and corridors, roll on the Passage table multiple 
/// times, extending the length and branches of any open passage on the map
/// until you arrive at a door or chamber.  Whenever you create a new passage, 
/// roll to determine its width.If the passage branches from another
/// passage roll a d12 on the Passage Width table.If it comes from a chamber, 
/// roll a d20 on that table, but the width of the passage must be at least 
/// 5 feet smaller than the longest dimension of the chamber.
/// </summary>
public class PassageWidthTable : RandomTable, IPassageWidthTable
{
    /// <summary>
    /// When generating passages and corridors, roll on the Passage table multiple 
    /// times, extending the length and branches of any open passage on the map
    /// until you arrive at a door or chamber.  Whenever you create a new passage, 
    /// roll to determine its width. If the passage branches from another
    /// passage roll a d12 on the Passage Width table. If it comes from a chamber, 
    /// roll a d20 on that table, but the width of the passage must be at least 
    /// 5 feet smaller than the longest dimension of the chamber.
    /// </summary>
    public PassageWidthTable()
    {
        Name = nameof(PassageWidthTable);
        ProperName = "Passage Width Table";
        TableType = TableTypeEnum.RandomDungeonTable;
        DiceSides = 20;
        Description =
            "The width of a passage";
    }

    /// PASSAGE WIDTH
    /// d20 Width
    /// 1-2  5 ft.
    /// 3-12  10 ft.
    /// 13-14  20 ft.
    /// 15-16  30 ft.
    /// 17  40 ft., with row of pillars down the middle
    /// 18  40 ft., with double row of pillars
    /// 19  40 ft.wide, 20 ft.high
    /// 20   40 ft.wide, 20 ft.high, gallery 10 ft.above floor
    /// allows access to level above
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
                #region Square, 20 x 20 ft.; passage on each wall
                //1   Square, 20 x 20 ft.; passage on each wall
                new RandomTableEntryViewModel
                {
                    Range = new Range(01, 01),
                    Name = nameof(StartingAreaEnum.Square20ft),
                },
                #endregion
            };
        }
    }
}
