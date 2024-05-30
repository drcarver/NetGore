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
    public class NPCClassTable : RandomTable, INPCClassTable
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
        public NPCClassTable()
        {
            Name = nameof(NPCClassTable);
            ProperName = "NPC Class Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "NPC Class Table";
        }

        //NPC CLASS
        //d20 Class
        //1 Barbarian 
        //2 Bard 
        //3-4 Cleric
        //5 Druid 
        //6-7 Fighter 
        //8 Monk 
        //9 Paladin
        //10 Ranger
        //11-14 Rogue
        //15 Sorcerer
        //16 Warlock
        //17-20 Wizard 
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
                    #region 1 Barbarian
                    //1 Barbarian
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(ClassEnum.Barbarian),
                        ProperName = "Barbarian",
                        Description = "Barbarian"
                    },
                    #endregion

                    #region 2 Bard
                    //2 Bard
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(ClassEnum.Bard),
                        ProperName = "Bard",
                        Description = "Bard"
                    },
                    #endregion

                    #region 3-4 Cleric
                    //3-4 Cleric
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 04),
                        Name = nameof(ClassEnum.Cleric),
                        ProperName = "Cleric",
                        Description = "Cleric"
                    },
                    #endregion

                    #region 5 Druid
                    //5 Druid
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(ClassEnum.Druid),
                        ProperName = "Druid",
                        Description = "Druid"
                    },
                    #endregion

                    #region 6-7 Fighter
                    //6-7 Fighter
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 07),
                        Name = nameof(ClassEnum.Fighter),
                        ProperName = "Fighter",
                        Description = "Fighter"
                    },
                    #endregion

                    #region 8 Monk
                    //8 Monk
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 08),
                        Name = nameof(ClassEnum.Monk),
                        ProperName = "Monk",
                        Description = "Monk"
                    },
                    #endregion

                    #region 9 Paladin
                    //9 Paladin
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(ClassEnum.Paladin),
                        ProperName = "Paladin",
                        Description = "Paladin"
                    },
                    #endregion

                    #region 10 Ranger
                    //10 Ranger
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(ClassEnum.Ranger),
                        ProperName = "Ranger",
                        Description = "Ranger"
                    },
                    #endregion

                    #region 11-14 Rogue
                    //11-14 Rogue
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 14),
                        Name = nameof(ClassEnum.Rogue),
                        ProperName = "Rogue",
                        Description = "Rogue"
                    },
                    #endregion

                    #region 15 Sorcerer
                    //15 Sorcerer
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 15),
                        Name = nameof(ClassEnum.Sorcerer),
                        ProperName = "Sorcerer",
                        Description = "Sorcerer"
                    },
                    #endregion

                    #region 16 Warlock
                    //16 Warlock
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(ClassEnum.Warlock),
                        ProperName = "Warlock",
                        Description = "Warlock"
                    },
                    #endregion

                    #region 17-20 Wizard
                    //17-20 Wizard
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 20),
                        Name = nameof(ClassEnum.Wizard),
                        ProperName = "Wizard",
                        Description = "Wizard"
                    },
                    #endregion
                };
            }
        }
    }
}


    