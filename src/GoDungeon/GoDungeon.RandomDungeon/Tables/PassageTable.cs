using System;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Enum;
using GoDungeon.RandomDungeon.Interfaces;

namespace GoDungeon.RandomDungeon.Tables
{
    public class PassageTable : RandomTable, IPassageTable
    {
        /// <summary>
        /// When generating passages and corridors, roll on the Passage table multiple 
        /// times, extending the length and branches of any open passage on the map
        /// until you arrive at a door or chamber.  Whenever you create a new passage, 
        /// roll to determine its width.If the passage branches from another
        /// passage roll a d12 on the Passage Width table.If it comes from a chamber, 
        /// roll a d20 on that table, but the width of the passage must be at least 
        /// 5 feet smaller than the longest dimension of the chamber.
        /// </summary>
        public PassageTable()
        {
            Name = nameof(PassageTable);
            ProperName = "Passage Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description =
                "When generating passages and corridors, roll on the Passage table multiple times, extending the length and branches of any open passage on the map until you arrive at a door or chamber.  Whenever you create a new passage, roll to determine its width.If the passage branches from another passage roll a d12 on the Passage Width table.";
        }
 
        /// PASSAGE
        /// d20  Detail
        /// 1-2  Continue straight 30 ft., no doors or side passages
        /// 3   Continue straight 20 ft., door to the right, then an additional 
        ///     10 ft.ahead
        /// 4   Continue straight 20 ft., door to the left, then an additional 
        ///     10 ft.ahead
        /// 5   Continue straight 20 ft.; passage ends in a door 
        /// 6-7 Continue straight 20 ft., side passage to the right
        ///     then an additional 10 ft.ahead
        /// 8-9 Continue straight 20 ft., side passage to the left, then an 
        ///     additional 10 ft.ahead
        /// 10  Continue straight 20 ft.,comes to a dead end; 10 percent chance 
        ///     of a secret door
        /// 11-12  Continue straight 20 ft., then the passage turns left and
        ///     continues 10 ft.
        /// 13-14  Continue straight 20 ft., then the passage turns right and 
        ///     continues 10 ft.
        /// 15-19  Chamber (roll on the Chamber table)
        /// 20  Stairs* (roll on the Stairs table)
        /// * The existence of stairs presumes a dungeon with more than one level.
        ///     If you don't want a multilevel dungeon, reroll this result, use 
        ///     the stairs as an alternative entrance, or replace them with 
        ///     another feature of your choice.
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
                    #region 1-2  Continue straight 30 ft., no doors or side passages
                    //1-2  Continue straight 30 ft., no doors or side passages
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 02),
                        Name = nameof(PassageEnum.Straight30),
                        ProperName = "Continue straight 30 ft.",
                        Description = "Continue straight 30 ft., no doors or side passages",
                    },
                    #endregion

                    #region 3 Continue straight 20 ft., door to the right, then an additional 10 ft.ahead
                    //3 Continue straight 20 ft., door to the right, then an additional 10 ft.ahead
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(PassageEnum.Straight20DoorToRight),
                        ProperName = "Continue straight 20 ft., door to the right",
                        Description = "Continue straight 20 ft., door to the right, then an additional 10 ft.ahead",
                    },
                    #endregion

                    #region 4 Continue straight 20 ft., door to the left, then an additional 10 ft.ahead
                    //4 Continue straight 20 ft., door to the left, then an additional 10 ft.ahead
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(PassageEnum.Straight20DoorToLeft),
                        ProperName = "Continue straight 20 ft., door to the left",
                        Description = "Continue straight 20 ft., door to the left, then an additional 10 ft.ahead",
                    },
                    #endregion

                    #region 5   Continue straight 20 ft.; passage ends in a door
                    //5   Continue straight 20 ft.; passage ends in a door
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(PassageEnum.Straight20ToDoor),
                        ProperName = "Continue straight 20 ft.; passage ends in a door",
                        Description = "Continue straight 20 ft.; passage ends in a door",
                    },
                    #endregion

                    #region 6-7 Continue straight 20 ft., side passage to the right then an additional 10 ft.ahead
                    //6-7 Continue straight 20 ft., side passage to the right then an additional 10 ft.ahead
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 07),
                        Name = nameof(PassageEnum.Straight20PassageToTheRight),
                        ProperName = "Continue straight 20 ft., side passage to the right",
                        Description = "Continue straight 20 ft., side passage to the right then an additional 10 ft.ahead",
                    },
                    #endregion

                    #region 8-9 Continue straight 20 ft., side passage to the left, then an additional 10 ft.ahead
                    //8-9 Continue straight 20 ft., side passage to the left, then an additional 10 ft.ahead
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 09),
                        Name = nameof(PassageEnum.Straight20PassageToTheLeft),
                        ProperName = "Continue straight 20 ft., side passage to the left",
                        Description = "Continue straight 20 ft., side passage to the left, then an additional 10 ft.ahead",
                    },
                    #endregion

                    #region 10  Continue straight 20 ft.,comes to a dead end; 10 percent chance of a secret door
                    //10  Continue straight 20 ft.,comes to a dead end; 10 percent chance of a secret door
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(PassageEnum.Straight20DeadEnd),
                        ProperName = "Continue straight 20 ft.,comes to a dead end",
                        Description = "Continue straight 20 ft.,comes to a dead end; 10 percent chance of a secret door",
                    },
                    #endregion

                    #region 11-12  Continue straight 20 ft., then the passage turns left and continues 10 ft.
                    //11-12  Continue straight 20 ft., then the passage turns left and continues 10 ft.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 12),
                        Name = nameof(PassageEnum.Straight20LeftTurn),
                        ProperName = "Continue straight 20 ft., then turn left",
                        Description = "Continue straight 20 ft., then the passage turns left and continues 10 ft.",
                    },
                    #endregion

                    #region 13-14  Continue straight 20 ft., then the passage turns right and continues 10 ft.
                    //13-14  Continue straight 20 ft., then the passage turns right and continues 10 ft.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 14),
                        Name = nameof(PassageEnum.Straight20RightTurn),
                        ProperName = "Continue straight 20 ft., then turn right",
                        Description = "Continue straight 20 ft., then the passage turns right and continues 10 ft.",
                    },
                    #endregion

                    #region 15-19  Chamber (roll on the Chamber table)
                    //15-19  Chamber (roll on the Chamber table)
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 19),
                        Name = nameof(PassageEnum.Chamber),
                        ProperName = "Chamber",
                        Description = "Chamber",
                    },
                    #endregion

                    #region 20 Stairs
                    //20 Stairs
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(PassageEnum.Stairs),
                        ProperName = "Stairs",
                        Description = "Stairs",
                    },
                    #endregion
                };
            }
        }
    }
}
