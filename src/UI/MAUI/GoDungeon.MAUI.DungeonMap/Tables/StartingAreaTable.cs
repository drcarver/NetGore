using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.RandomDungeon.Tables;

namespace GoDungeon.MAUI.DungeonMap.Tables;

/// <summary>

/// STARTING AREA
/// The Starting Area table produces a chamber or a set of corridors at the
/// entrance to your dungeon.  When rolling for a random starting area, pick 
/// one of the doors or passages leading into the starting area as the
/// entrance to the dungeon as a whole.
///  <para>
/// Once you've selected the entrance, roll on the appropriate table for 
/// each passage or door leading away from the starting area.Passages each 
/// extend 10 feet beyond the starting area.After that point, check on the 
/// Passage table for each passage to determine what lies beyond. Use the 
/// Beyond a Door table to determine what lies behind doors and secret doors.
///  </para>
/// </summary>
public class StartingAreaTable : RandomTable, IStartingAreaTable
{
    /// <summary>
    /// The Starting Area table produces a chamber or a set of corridors at the
    /// entrance to your dungeon.  When rolling for a random starting area, pick 
    /// one of the doors or passages leading into the starting area as the
    /// entrance to the dungeon as a whole.
    /// </summary>
    public StartingAreaTable()
    {
        Name = nameof(StartingAreaTable);
        ProperName = "Starting Area Table";
        TableType = TableTypeEnum.RandomDungeonTable;
        DiceSides = 10;
        Description =
            "The Starting Area table produces a chamber or a set of corridors at the  entrance to your dungeon.  When rolling for a random starting area, pick one of the doors or passages leading into the starting area as the entrance to the dungeon as a whole.";
    }

    //STARTING AREA
    //d10  Configuration
    //1   Square, 20 x 20 ft.; passage on each wall
    //2   Square, 20 x 20 ft.; door on two walls, passage in third wall
    //3   Square, 40 x 40 ft.; doors on three walls
    //4   Rectangle, 80 x 20 ft., with row of pillars down the middle; two passages leading from each
    //long wall, doors on each short wall
    //5   Rectangle, 20 x 40 ft.; passage on each wall
    //6   Circle, 40 ft.diameter; one passage at each cardinal direction
    //7   Circle, 40 ft.diameter; one passage in each cardinal direction; well in middle of room(might
    //lead down to lower level)
    //8   Square, 20 x 20 ft.; door on two walls, passage on third wall, secret door on fourth wall
    //9   Passage, 10 ft.wide; T intersection
    //10  Passage, 10 ft.wide; four-way intersection
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

                #region Square, 20 x 20 ft.; door on two walls, passage in third wall
                //2   Square, 20 x 20 ft.; door on two walls, passage in third wall
                new RandomTableEntryViewModel
                {
                    Range = new Range(02, 02),
                    Name = nameof(StartingAreaEnum.Square20ftPlusPassage),
                },
                #endregion

                #region Square, 40 x 40 ft.; doors on three walls
                //3   Square, 40 x 40 ft.; doors on three walls
                new RandomTableEntryViewModel
                {
                    Range = new Range(03, 03),
                    Name = nameof(StartingAreaEnum.Square20ftPlusPassage),
                },
                #endregion

                #region Rectangle, 80 x 20 ft., with row of pillars down the middle; two passages leading from each
                //4   Rectangle, 80 x 20 ft., with row of pillars down the middle; two passages leading from each
                new RandomTableEntryViewModel
                {
                    Range = new Range(04, 04),
                    Name = nameof(StartingAreaEnum.Rectangle80by20),
                },
                #endregion

                #region Rectangle, 20 x 40 ft.; passage on each wall
                //5   Rectangle, 20 x 40 ft.; passage on each wall
                new RandomTableEntryViewModel
                {
                    Range = new Range(05, 05),
                    Name = nameof(StartingAreaEnum.Rectangle20by40),
                },
                #endregion

                #region Circle, 40 ft.diameter; one passage at each cardinal direction
                //6   Circle, 40 ft.diameter; one passage at each cardinal direction
                new RandomTableEntryViewModel
                {
                    Range = new Range(06, 06),
                    Name = nameof(StartingAreaEnum.Circle20),
                },
                #endregion

                #region Circle, 40 ft.diameter; one passage in each cardinal direction; well in middle of room(might lead down to lower level)
                //7   Circle, 40 ft.diameter; one passage in each cardinal direction; well in middle of room(might
                //lead down to lower level)
                new RandomTableEntryViewModel
                {
                    Range = new Range(07, 07),
                    Name = nameof(StartingAreaEnum.Circle20WithWell),
                },
                #endregion

                #region Square, 20 x 20 ft.; door on two walls, passage on third wall, secret door on fourth wall
                //8   Square, 20 x 20 ft.; door on two walls, passage on third wall, secret door on fourth wall
                new RandomTableEntryViewModel
                {
                    Range = new Range(08, 08),
                    Name = nameof(StartingAreaEnum.Square20SecretDoor),
                },
                #endregion

                #region Passage, 10 ft.wide; T intersection
                //9   Passage, 10 ft.wide; T intersection
                new RandomTableEntryViewModel
                {
                    Range = new Range(09, 09),
                    Name = nameof(StartingAreaEnum.Passage10TIntersection),
                },
                #endregion

                #region Passage, 10 ft.wide; four-way intersection
                //10  Passage, 10 ft.wide; four-way intersection
                new RandomTableEntryViewModel
                {
                    Range = new Range(09, 09),
                    Name = nameof(StartingAreaEnum.Passage104WayIntersection),
                },
                #endregion
            };
        }
    }
}
