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
    public class DungeonCreatorTable : RandomTable, IDungeonCreatorTable
    {
        /// <summary>
        /// A dungeon reflects its creators. A lost temple of the
        /// yuan-ti, choked by overgrown jungle plants, might
        /// feature ramps instead of stairs. Caverns carved by a
        /// beholder·s disintegration eye ray have walls that are
        /// un naturally smooth, and the beholder's lair might
        /// include vertical shafts connecting different levels.
        /// Amphibious monsters such as kuo-toa and aboleths use
        /// water to protect the innermost reaches of their lairs
        /// from air-breathing intruders.
        /// </summary>
        public DungeonCreatorTable()
        {
            Name = nameof(DungeonCreatorTable);
            ProperName = "Dungeon Creator Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "A dungeon reflects its creators. A lost temple of the yuan-ti, choked by overgrown jungle plants, might feature ramps instead of stairs. Caverns carved by a beholder·s disintegration eye ray have walls that are unnaturally smooth, and the beholder's lair might include vertical shafts connecting different levels. Amphibious monsters such as kuo-toa and aboleths use water to protect the innermost reaches of their lairs from air-breathing intruders.";
        }

        //DUNGEON CREATOR
        //d20 Creator
        //1 Beholder
        //2-4 Cult or religious group (roll on the Cults and
        //Religious Groups table to determine specifics)
        //5-8 Dwarves
        //9 Elves (including drow)
        //10 Giants
        //11 Hobgoblins
        //12-15 Humans (roll on the NPC Alignment and NPC
        //Class tables to determine specifics)
        //16 Kuo-toa
        //17 Lich
        //18 Mindflayers
        //19 Yuan-ti
        //20 No creator (natural caverns)
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
                    #region 1 Beholder
                    //1 Beholder
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(DungeonCreatorEnum.Beholder),
                        ProperName = "Beholder",
                        Description = "Beholder"
                    },
                    #endregion

                    #region 2-4 Cult or religious group
                    //2-4 Cult or religious group
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 04),
                        Name = nameof(DungeonCreatorEnum.Cult),
                        ProperName = "Cult or religious group",
                        Description = "Cult or religious group"
                    },
                    #endregion

                    #region 5-8 Dwarves
                    //5-8 Dwarves
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 08),
                        Name = nameof(DungeonCreatorEnum.Dwarves),
                        ProperName = "Dwarves",
                        Description = "Dwarves"
                    },
                    #endregion

                    #region 9 Elves (including drow)
                    //9 Elves (including drow)
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(DungeonCreatorEnum.Elves),
                        ProperName = "Elves",
                        Description = "Elves (including drow)"
                    },
                    #endregion

                    #region 10 Giants
                    //10 Giants
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(DungeonCreatorEnum.Giants),
                        ProperName = "Giants",
                        Description = "Giants"
                    },
                    #endregion

                    #region 11 Hobgoblins
                    //11 Hobgoblins
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(DungeonCreatorEnum.Hobgoblins),
                        ProperName = "Hobgoblins",
                        Description = "Hobgoblins"
                    },
                    #endregion

                    #region 12-15 Humans
                    //12-15 Humans
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 15),
                        Name = nameof(DungeonCreatorEnum.Humans),
                        ProperName = "Humans",
                        Description = "Humans"
                    },
                    #endregion

                    #region 16 Kuo-toa
                    //16 Kuo-toa
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(DungeonCreatorEnum.Kuotoa),
                        ProperName = "Kuo-toa",
                        Description = "Kuo-toa"
                    },
                    #endregion

                    #region 17 Lich
                    //17 Lich
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(DungeonCreatorEnum.Lich),
                        ProperName = "Lich",
                        Description = "Lich"
                    },
                    #endregion

                    #region 18 Mindflayers
                    //18 Mindflayers
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(DungeonCreatorEnum.Mindflayers),
                        ProperName = "Mindflayers",
                        Description = "Mindflayers"
                    },
                    #endregion

                    #region 19 Yuan-ti
                    //19 Yuan-ti
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(DungeonCreatorEnum.Yuanti),
                        ProperName = "Yuan-ti",
                        Description = "Yuan-ti"
                    },
                    #endregion

                    #region 20 No creator (natural caverns)
                    //20 No creator (natural caverns)
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(DungeonCreatorEnum.NoCreator),
                        ProperName = "No creator",
                        Description = "No creator (natural caverns)"
                    },
                    #endregion
                };
            }
        }
    }
}
