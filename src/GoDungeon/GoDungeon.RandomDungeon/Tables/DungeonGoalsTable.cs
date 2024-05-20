using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Enum;
using GoDungeon.RandomDungeon.Interfaces;

using Syncfusion.DocIO.DLS;

namespace GoDungeon.RandomDungeon.Tables
{
    public class DungeonGoalsTable : RandomTable, IDungeonGoalsTable
    {
        /// <summary>
        /// The Dungeon Goals table provides common goals
        /// that drive or lure adventurers into dungeons. The 
        /// wilderness Goals table provides similar inspiration for
        /// an adventure focused on outdoor exploration. The Other
        /// goals table suggests location-based adventures that
        /// don't fit neatly into the first two categories.
        /// </summary>
        public DungeonGoalsTable()
        {
            Name = nameof(DungeonGoalsTable);
            ProperName = "Dungeon Goals Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "The Dungeon Goals table provides common goals that drive or lure adventurers into dungeons. The wilderness Goals table provides similar inspiration for an adventure focused on outdoor exploration. The Other goals table suggests location-based adventures that don't fit neatly into the first two categories.";
        }

        //DUNGEON GOALS
        //d20 Goal
        //1. Stop the dungeon's monstrous inhabitants from
        //raiding the surface world .
        //2 Foil a villain's evil scheme.
        //3 Destroy a magical threat inside the dungeon.
        //4 Acquire treasure
        //5 Find a particular item for a specific purpose.
        //6 Retrieve a stolen item hidden in the dungeon.
        //7 Find information needed for a special purpose.
        //8 Rescue a captive.
        //9 Discover the fate of a previous adventuring party.
        //10 Find an NPC who disappeared in the area.
        //11 Slay a dragon or some other challenging monster.
        //12 Discover the nature and origin of a strange location
        //or phenomenon.
        //13 Pursue fleeing foes taking refuge in the dungeon.
        //14 Escape from captivity in the dungeon.
        //15 Clear a ruin so it can be rebuilt and reoccupied.
        //16 Discover why a villain is interested in the dungeon.
        //17 Win a bet or complete a rite of passage by surviving
        //in the dungeon for a certain amount of time.
        //18 Parley with a villain in the dungeon.
        //19 Hide from a threat outside the dungeon.
        //20 Roll twice, ignoring results of 20. 
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
                    #region 1. Stop the dungeon's monstrous inhabitants from raiding the surface world .
                    //1. Stop the dungeon's monstrous inhabitants from raiding the surface world
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(DungeonGoalEnum.StopInhabitants),
                        ProperName = "Stop the inhabitants from raiding",
                        Description = "Stop the dungeon's monstrous inhabitants from raiding the surface world"
                    },
                    #endregion

                    #region 2 Foil a villain's evil scheme.
                    //2 Foil a villain's evil scheme.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(DungeonGoalEnum.FoilVillain),
                        ProperName = "Foil a villain's evil scheme.",
                        Description = "Foil a villain's evil scheme."
                    },
                    #endregion

                    #region 3 Destroy a magical threat inside the dungeon.
                    //3 Destroy a magical threat inside the dungeon.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(DungeonGoalEnum.DestroyMagicalThreat),
                        ProperName = "Destroy a magical threat inside the dungeon.",
                        Description = "Destroy a magical threat inside the dungeon."
                    },
                    #endregion

                    #region 4 Acquire treasure
                    //4 Acquire treasure
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(DungeonGoalEnum.AcquireTreasure),
                        ProperName = "Acquire treasure",
                        Description = "Acquire treasure"
                    },
                    #endregion

                    #region 5 Find a particular item for a specific purpose.
                    //5 Find a particular item for a specific purpose.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(DungeonGoalEnum.FindAItem),
                        ProperName = "Find an item for a purpose.",
                        Description = "Find a particular item for a specific purpose."
                    },
                    #endregion

                    #region 6 Retrieve a stolen item hidden in the dungeon.
                    //6 Retrieve a stolen item hidden in the dungeon.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(DungeonGoalEnum.RetrieveAStolenItem),
                        ProperName = "Retrieve a stolen item",
                        Description = "Retrieve a stolen item hidden in the dungeon."
                    },
                    #endregion

                    #region 7 Find information needed for a special purpose.
                    //7 Find information needed for a special purpose.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 07),
                        Name = nameof(DungeonGoalEnum.FindInformation),
                        ProperName = "Find information",
                        Description = "Find information needed for a special purpose."
                    },
                    #endregion

                    #region 8 Rescue a captive.
                    //8 Rescue a captive.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 08),
                        Name = nameof(DungeonGoalEnum.RescueACaptive),
                        ProperName = "Rescue a captive.",
                        Description = "Rescue a captive."
                    },
                    #endregion

                    #region 9 Discover the fate of a previous adventuring party.
                    //9 Discover the fate of a previous adventuring party.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(DungeonGoalEnum.DiscoverFateAParty),
                        ProperName = "Discover fate of adventuring party.",
                        Description = "Discover the fate of a previous adventuring party."
                    },
                    #endregion

                    #region 10 Find an NPC who disappeared in the area.
                    //10 Find an NPC who disappeared in the area.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(DungeonGoalEnum.FindAnNPC),
                        ProperName = "Find an NPC",
                        Description = "Find an NPC who disappeared in the area."
                    },
                    #endregion

                    #region 11 Slay a dragon or some other challenging monster.
                    //11 Slay a dragon or some other challenging monster.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(DungeonGoalEnum.SlayADragon),
                        ProperName = "Slay a dragon.",
                        Description = "Slay a dragon or some other challenging monster."
                    },
                    #endregion

                    #region 12 Discover the nature and origin of a strange location or phenomenon.
                    //12 Discover the nature and origin of a strange location or phenomenon.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(DungeonGoalEnum.DiscoverTheNatureOfAPhenomenon),
                        ProperName = "Discover the nature of a phenomenon.",
                        Description = "Discover the nature and origin of a strange location or phenomenon."
                    },
                    #endregion

                    #region 13 Pursue fleeing foes taking refuge in the dungeon.
                    //13 Pursue fleeing foes taking refuge in the dungeon.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 13),
                        Name = nameof(DungeonGoalEnum.PursueFleeingFoes),
                        ProperName = "Pursue fleeing foes",
                        Description = "Pursue fleeing foes taking refuge in the dungeon."
                    },
                    #endregion

                    #region 14 Escape from captivity in the dungeon.
                    //14 Escape from captivity in the dungeon.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(14, 14),
                        Name = nameof(DungeonGoalEnum.EscapeFromCaptivity),
                        ProperName = "Escape from captivity",
                        Description = "Escape from captivity in the dungeon."
                    },
                    #endregion

                    #region 15 Clear a ruin so it can be rebuilt and reoccupied.
                    //15 Clear a ruin so it can be rebuilt and reoccupied.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 15),
                        Name = nameof(DungeonGoalEnum.ClearARuin),
                        ProperName = "Clear a ruin",
                        Description = "Clear a ruin so it can be rebuilt and reoccupied."
                    },
                    #endregion

                    #region 16 Discover why a villain is interested in the dungeon.
                    //16 Discover why a villain is interested in the dungeon.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(DungeonGoalEnum.WhyAVillainIsInterested),
                        ProperName = "Why a villain is interested",
                        Description = "Discover why a villain is interested in the dungeon."
                    },
                    #endregion

                    #region 17 Win a bet or complete a rite of passage by surviving in the dungeon for a certain amount of time.
                    //17 Win a bet or complete a rite of passage by surviving in the dungeon for a certain amount of time.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(DungeonGoalEnum.WinABet),
                        ProperName = "Win a bet",
                        Description = "Win a bet or complete a rite of passage by surviving in the dungeon for a certain amount of time."
                    },
                    #endregion

                    #region 18 Parley with a villain in the dungeon.
                    //18 Parley with a villain in the dungeon.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(DungeonGoalEnum.ParleyWithAVillain),
                        ProperName = "Parley with a villain in the dungeon.",
                        Description = "Parley with a villain in the dungeon."
                    },
                    #endregion

                    #region 19 Hide from a threat outside the dungeon.
                    //19 Hide from a threat outside the dungeon.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(DungeonGoalEnum.HideFromAThreat),
                        ProperName = "Hide from a threat",
                        Description = "Hide from a threat outside the dungeon."
                    },
                    #endregion

                    #region 20 Roll twice, ignoring results of 20.
                    //20 Roll twice, ignoring results of 20.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(DungeonGoalEnum.RollTwice),
                        ProperName = "Roll twice",
                        Description = "Roll twice, ignoring results of 20."
                    },
                    #endregion
                };
            }
        }
    }
}

