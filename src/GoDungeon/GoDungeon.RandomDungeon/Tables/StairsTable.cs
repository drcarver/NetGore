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
    public class StairsTable : RandomTable, IStairsTable
    {
        /// <summary>
        /// Stairs can include any means of going up and down, including ramps,
        /// chimneys, open shafts, elevators, and ladders. If your dungeon
        /// has more than one level, the amount of space between levels
        /// is up to you.A distance of 30 feet works fine for most dungeons.
        /// </summary>
        public StairsTable()
        {
            Name = nameof(StairsTable);
            ProperName = "Stairs Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description =
                "Stairs can include any means of going up and down, including ramps, chimneys, open shafts, elevators, and ladders. If your dungeon has more than one level, the amount of space between levels is up to you. A distance of 30 feet works fine for most dungeons.";
        }

        //STAIRS
        //d20  Stairs
        //1-4  Down one level to a chamber
        //5-8  Down one level to a passage 20 ft. long
        //9   Down two levels to a chamber
        //10  Down two levels to a passage 20 ft. long
        //11  Down three levels to a chamber
        //12  Down three levels to a passage 20 ft. long
        //13  Up one level to a chamber
        //14  Up one level to a passage 20 ft. long
        //15  Up to a dead end
        //16  Down to a dead end
        //17  Chimney up one level to a passage 20 ft. long
        //18  Chimney up two levels to a passage 20 ft. long
        //19  Shaft(with or without elevator) down one level to a chamber
        //20  Shaft(with or without elevator) up one level to a chamber and down one level to a chamber
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
                    #region 1-4  Down one level to a chamber
                    //1-4  Down one level to a chamber
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 04),
                        Name = nameof(StairsEnum.DownOneToAChamber),
                        ProperName = "Down one to a chamber",
                        Description = "Down one level to a chamber",
                    },
                    #endregion

                    #region 5-8  Down one level to a passage 20 ft. long
                    //5-8  Down one level to a passage 20 ft. long
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 08),
                        Name = nameof(StairsEnum.DownOneToAPassage),
                        ProperName = "Down one to a passage",
                        Description = "Down one level to a passage 20 ft. long",
                    },
                    #endregion

                    #region 9   Down two levels to a chamber
                    //9   Down two levels to a chamber
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(StairsEnum.DownTwoToAChamber),
                        ProperName = "Down two to a chamber",
                        Description = "Down two levels to a chamber",
                    },
                    #endregion

                    #region 10  Down two levels to a passage 20 ft. long
                    //10  Down two levels to a passage 20 ft. long
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(StairsEnum.DownTwoToAChamber),
                        ProperName = "Down two to a chamber",
                        Description = "Down two levels to a passage 20 ft. long",
                    },
                    #endregion

                    #region 11  Down three levels to a chamber
                    //11  Down three levels to a chamber
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(StairsEnum.DownThreeToAChamber),
                        ProperName = "Down three to a chamber",
                        Description = "Down three levels to a chamber",
                    },
                    #endregion

                    #region 12  Down three levels to a passage 20 ft. long
                    //12  Down three levels to a passage 20 ft. long
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(StairsEnum.DownThreeToAPassage),
                        ProperName = "Down three to a passage",
                        Description = "Down three levels to a passage 20 ft. long",
                    },
                    #endregion

                    #region 13  Up one level to a chamber
                    //13  Up one level to a chamber
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 13),
                        Name = nameof(StairsEnum.UpOneToAChamber),
                        ProperName = "Up one to a chamber",
                        Description = "Up one level to a chamber",
                    },
                    #endregion

                    #region 14  Up one level to a passage 20 ft. long
                    //14  Up one level to a passage 20 ft. long
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(14, 14),
                        Name = nameof(StairsEnum.UpOneToAPassage),
                        ProperName = "Up one to a passage",
                        Description = "Up one level to a passage 20 ft. long",
                    },
                    #endregion

                    #region 15  Up to a dead end
                    //15  Up to a dead end
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 15),
                        Name = nameof(StairsEnum.UpToADeadEnd),
                        ProperName = "Up to a dead end",
                        Description = "Up to a dead end",
                    },
                    #endregion

                    #region 16  Down to a dead end
                    //16  Down to a dead end
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(StairsEnum.DownToADeadEnd),
                        ProperName = "Down to a dead end",
                        Description = "Down to a dead end",
                    },
                    #endregion

                    #region 17  Chimney up one level to a passage 20 ft. long
                    //17  Chimney up one level to a passage 20 ft. long
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(StairsEnum.ChimneyUpOneToAPassage),
                        ProperName = "Chimney up one level to a passage",
                        Description = "Chimney up one level to a passage 20 ft. long",
                    },
                    #endregion

                    #region 18  Chimney up two levels to a passage 20 ft. long
                    //18  Chimney up two levels to a passage 20 ft. long
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(StairsEnum.ChimneyUpTwoToAPassage),
                        ProperName = "Chimney up two levels to a passage 20 ft. long",
                        Description = "Chimney up two levels to a passage 20 ft. long",
                    },
                    #endregion

                    #region 19 Shaft(with or without elevator) down one level to a chamber
                    //19 Shaft(with or without elevator) down one level to a chamber
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(StairsEnum.ShaftDownOneToAChamber),
                        ProperName = "Shaft down one level to a chamber",
                        Description = "Shaft (with or without elevator) down one level to a chamber",
                    },
                    #endregion

                    #region 20  Shaft(with or without elevator) up one level to a chamber and down one level to a chamber
                    //20  Shaft(with or without elevator) up one level to a chamber and down one level to a chamber
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(StairsEnum.ShaftDownAndUpOneLevel),
                        ProperName = "Shaft up one level and down one level",
                        Description = "Shaft (with or without elevator) up one level to a chamber and down one level to a chamber",
                    },
                    #endregion
                };
            }
        }
    }
}
