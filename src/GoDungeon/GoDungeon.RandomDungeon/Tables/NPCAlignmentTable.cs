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
    public class NPCAlignmentTable : RandomTable, INPCAlignmentTable
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
        public NPCAlignmentTable()
        {
            Name = nameof(NPCAlignmentTable);
            ProperName = "NPC Alignment Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "NPC Alignment Table";
        }

        //NPC ALIGNMENT
        //d20 Alignment 
        //1-2 Lawful good 
        //3-4 Neutral good 
        //5-6 Chaotic good 
        //7-9 Lawful neutral 
        //10-11 Neutral
        //12 Chaotic neutral
        //13-15 Lawful evil
        //16-18 Neutral evil
        //19-20 Chaotic evil
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
                    #region 1-2 Lawful good
                    //1-2 Lawful good
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 02),
                        Name = nameof(AlignmentEnum.LawfulGood),
                        ProperName = "Lawful good",
                        Description = "Lawful good"
                    },
                    #endregion

                    #region 3-4 Neutral good
                    //3-4 Neutral good
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 04),
                        Name = nameof(AlignmentEnum.NeutralGood),
                        ProperName = "Neutral good",
                        Description = "Neutral good"
                    },
                    #endregion

                    #region 5-6 Chaotic good
                    //5-6 Chaotic good
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 06),
                        Name = nameof(AlignmentEnum.ChaoticGood),
                        ProperName = "Chaotic good",
                        Description = "Chaotic good"
                    },
                    #endregion

                    #region 7-9 Lawful neutral
                    //7-9 Lawful neutral
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 09),
                        Name = nameof(AlignmentEnum.LawfulNeutral),
                        ProperName = "Lawful neutral",
                        Description = "Lawful neutral"
                    },
                    #endregion

                    #region 10-11 Neutral
                    //10-11 Neutral
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 11),
                        Name = nameof(AlignmentEnum.Neutral),
                        ProperName = "Neutral",
                        Description = "Neutral"
                    },
                    #endregion

                    #region 12 Chaotic neutral
                    //12 Chaotic neutral
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(AlignmentEnum.ChaoticNeutral),
                        ProperName = "Chaotic neutral",
                        Description = "Chaotic neutral"
                    },
                    #endregion

                    #region 13-15 Lawful evil
                    //13-15 Lawful evil
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 15),
                        Name = nameof(AlignmentEnum.LawfulEvil),
                        ProperName = "Lawful evil",
                        Description = "Lawful evil"
                    },
                    #endregion

                    #region 16-18 Neutral evil
                    //16-18 Neutral evil
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 18),
                        Name = nameof(AlignmentEnum.NeutralEvil),
                        ProperName = "Neutral evil",
                        Description = "Neutral evil"
                    },
                    #endregion

                    #region 19-20 Chaotic evil
                    //19-20 Chaotic evil
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 20),
                        Name = nameof(AlignmentEnum.ChaoticEvil),
                        ProperName = "Chaotic evil",
                        Description = "Chaotic evil"
                    },
                    #endregion
                };
            }
        }
    }
}


    