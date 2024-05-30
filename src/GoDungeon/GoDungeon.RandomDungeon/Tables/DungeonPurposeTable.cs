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
    /// <summary>
    /// </summary>
    public class DungeonPurposeTable : RandomTable, IDungeonPurposeTable
    {
        /// <summary>
        /// Except in the case of a natural cavern, a dungeon is crafted and
        /// inhabited for a specific purpose that influences its design and
        /// features. You can choose a purpose from the Dungeon Purpose table,
        /// roll one at random, or use your own ideas.    
        /// </summary>
        public DungeonPurposeTable()
        {
            Name = nameof(DungeonPurposeTable);
            ProperName = "Dungeon Purpose Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description =
                "Except in the case of a natural cavern, a dungeon is crafted and inhabited for a specific purpose that influences its design and features. You can choose a purpose from the Dungeon Purpose table, roll one at random, or use your own ideas.";
        }

        //DUNGEON PURPOSE
        //d20 Purpose
        //01 Death trap
        //2-5  Lair
        //6   Maze
        //7-9   Mine
        //10  Planar gate
        //11-14  Stronghold
        //15-17  Temple or shrine
        //18-19  Tomb
        //20   Treasure vault
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
                    #region 01 Death trap
                    // 01 Death trap
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(DungeonPurposeEnum.DeathTrap),
                        ProperName = "Death trap",
                        Description = "This dungeon is built to eliminate any creature that dares to enter it. A death trap might guard the treasure of an insane wizard, or it might be designed might guard the treasure of an insane wizard, or it might be designed to lure adventurers to their demise for some nefarious purpose, such as to feed souls to a lich's phylactery.\r\n"
                    },
                    #endregion

                    #region 2-5  Lair
                    //2-5  Lair
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 05),
                        Name = nameof(DungeonPurposeEnum.Lair),
                        ProperName = "Lair",
                        Description = "A lair is a place where monsters live.Typical lairs include ruins and caves"
                    },
                    #endregion

                    #region 6   Maze
                    //6   Maze
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(DungeonPurposeEnum.Maze),
                        ProperName = "Maze",
                        Description = "A maze is intended to deceive or confuse those who enter it. Some mazes are elaborate obstacles that protect treasure, while others are gauntlets for prisoners banished there to be hunted and devoured by the monsters within."
                    },
                    #endregion

                    #region 7-9   Mine
                    //7-9   Mine
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 09),
                        Name = nameof(DungeonPurposeEnum.Mine),
                        ProperName = "Mine",
                        Description = "An abandoned mine can quickly become infested with monsters, while miners who delve too deep can break through into the Underdark."
                    },
                    #endregion

                    #region 10  Planar gate
                    //10  Planar gate
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(DungeonPurposeEnum.PlanarGate),
                        ProperName = "Planar gate",
                        Description = "Dungeons built around planar portals are often transformed by the planar energy seeping out through those portals."
                    },
                    #endregion

                    #region 11-14  Stronghold
                    //11-14  Stronghold
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 14),
                        Name = nameof(DungeonPurposeEnum.Stronghold),
                        ProperName = "Stronghold",
                        Description = "A stronghold dungeon provides a secure base of operations for villains and monsters. It is usually ruled by a powerful individual, such as a wizard, vampire, or dragon, and it is larger and more complex than a simple lair."
                    },
                    #endregion

                    #region 15-17  Temple or shrine
                    //15-17  Temple or shrine
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 17),
                        Name = nameof(DungeonPurposeEnum.TempleorShrine),
                        ProperName = "Temple or shrine",
                        Description = "This dungeon is consecrated to a deity or other planar entity. The entity's worshipers control the dungeon and conduct their rites there."
                    },
                    #endregion

                    #region 18-19  Tomb
                    //18-19  Tomb
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 19),
                        Name = nameof(DungeonPurposeEnum.Tomb),
                        ProperName = "Tomb",
                        Description = "Tombs are magnets for treasure hunters, as well as monsters that hunger for the bones of the dead."
                    },
                    #endregion

                    #region 20   Treasure vault
                    //20   Treasure vault
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(DungeonPurposeEnum.TreasureVault),
                        ProperName = "Treasure vault",
                        Description = "Built to protect powerful magic items and great material wealth, treasure vault dungeons are heavily guarded by monsters and traps."
                    },
                    #endregion
                };
            }
        }
    }
}
