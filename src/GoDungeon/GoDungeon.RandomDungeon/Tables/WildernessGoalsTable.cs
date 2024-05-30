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
    public class WildernessGoalsTable : RandomTable, IWildernessGoalsTable
    {
        public WildernessGoalsTable()
        {
            Name = nameof(WildernessGoalsTable);
            ProperName = "Wilderness Goals Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "Wilderness Goals Table";
        }

        //WILDERNESS GOALS
        //d20 Goal
        //1 Locate a dungeon or other site of interest (roll on
        //the Dungeon Goals table to find out why).
        //2 Assess the scope of a natural or unnatural disaster.
        //3 Escort an NPC to a destination .
        //4 Arrive at a destination without being seen by the
        //villain's forces.
        //5 Stop monsters from raiding caravans and farms.
        //6 Establish trade with a distant town.
        //7 Protect a caravan traveling to a distant town .
        //8 Map a new land.
        //9 Find a place to establish a colony.
        //10 Find a natural resource.
        //11 Hunt a specific monster.
        //12 Return home from a distant place.
        //13 Obtain information from a reclusive hermit.
        //14 Find an object that was lost in the wilds.
        //15 Discover the fate of a missing group of explorers.
        //16 Pursue fleeing foes.
        //17 Assess the size of an approaching army.
        //18 Escape the reign of a tyrant.
        //19 Protect a wilderness site from attackers.
        //20 Roll twice, again ignoring results of 20.
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
                    #region 1 Locate a dungeon or other site of interest (roll on the Dungeon Goals table to find out why).
                    //1 Locate a dungeon or other site of interest (roll on the Dungeon Goals table to find out why).
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(WildernessGoalsEnum.LocateADungeon),
                        ProperName = "Locate a dungeon",
                        Description = "Locate a dungeon or other site of interest (roll on the Dungeon Goals table to find out why)."
                    },
                    #endregion

                    #region 2 Assess the scope of a natural or unnatural disaster.
                    //2 Assess the scope of a natural or unnatural disaster.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(WildernessGoalsEnum.AssessAUnnaturalDisaster),
                        ProperName = "Assess a unnatural disaster.",
                        Description = "Assess the scope of a natural or unnatural disaster."
                    },
                    #endregion

                    #region 3 Escort an NPC to a destination
                    //3 Escort an NPC to a destination
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(WildernessGoalsEnum.EscortAnNPC),
                        ProperName = "Escort an NPC",
                        Description = "Escort an NPC to a destination"
                    },
                    #endregion

                    #region 4 Arrive at a destination without being seen by the villain's forces.
                    //4 Arrive at a destination without being seen by the villain's forces.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(WildernessGoalsEnum.ArriveAtADestination),
                        ProperName = "Arrive at a destination",
                        Description = "Arrive at a destination without being seen by the villain's forces."
                    },
                    #endregion

                    #region 5 Stop monsters from raiding caravans and farms.
                    //5 Stop monsters from raiding caravans and farms.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(WildernessGoalsEnum.StopMonstersFromRaiding),
                        ProperName = "Stop monsters from raiding",
                        Description = "Stop monsters from raiding caravans and farms."
                    },
                    #endregion

                    #region 6 Establish trade with a distant town.
                    //6 Establish trade with a distant town.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(WildernessGoalsEnum.EstablishTrade),
                        ProperName = "Establish trade",
                        Description = "Establish trade with a distant town."
                    },
                    #endregion

                    #region 7 Protect a caravan traveling to a distant town 
                    //7 Protect a caravan traveling to a distant town 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 07),
                        Name = nameof(WildernessGoalsEnum.ProtectACaravan),
                        ProperName = "Protect a caravan",
                        Description = "Protect a caravan traveling to a distant town"
                    },
                    #endregion

                    #region 8 Map a new land. 
                    //8 Map a new land. 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 08),
                        Name = nameof(WildernessGoalsEnum.MapANewLand),
                        ProperName = "Map a new land.",
                        Description = "Map a new land."
                    },
                    #endregion

                    #region 9 Find a place to establish a colony. 
                    //9 Find a place to establish a colony.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(WildernessGoalsEnum.EstablishAColony),
                        ProperName = "Establish a colony.",
                        Description = "Find a place to establish a colony."
                    },
                    #endregion

                    #region 10 Find a place to establish a colony. 
                    //10 Find a place to establish a colony.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(WildernessGoalsEnum.FindANaturalResource),
                        ProperName = "Find a natural resource.",
                        Description = "Find a natural resource."
                    },
                    #endregion

                    #region 11 Hunt a specific monster. 
                    //11 Hunt a specific monster.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(WildernessGoalsEnum.HuntASpecificMonster),
                        ProperName = "Hunt a specific monster.",
                        Description = "Hunt a specific monster."
                    },
                    #endregion

                    #region 12 Return home from a distant place. 
                    //12 Return home from a distant place.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(WildernessGoalsEnum.ReturnHome),
                        ProperName = "Return home",
                        Description = "Return home from a distant place."
                    },
                    #endregion

                    #region 13 Obtain information from a reclusive hermit. 
                    //13 Obtain information from a reclusive hermit.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 13),
                        Name = nameof(WildernessGoalsEnum.ObtainInformation),
                        ProperName = "Obtain information",
                        Description = "Obtain information from a reclusive hermit."
                    },
                    #endregion

                    #region 14 Find an object that was lost in the wilds. 
                    //14 Find an object that was lost in the wilds.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(14, 14),
                        Name = nameof(WildernessGoalsEnum.FindAnObject),
                        ProperName = "Find an object",
                        Description = "Find an object that was lost in the wilds."
                    },
                    #endregion

                    #region 15 Discover the fate of a missing group of explorers. 
                    //15 Discover the fate of a missing group of explorers.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 15),
                        Name = nameof(WildernessGoalsEnum.DiscoverTheFateExplorers),
                        ProperName = "Discover the fate explorers.",
                        Description = "Discover the fate of a missing group of explorers."
                    },
                    #endregion

                    #region 16 Pursue fleeing foes. 
                    //16 Pursue fleeing foes.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(WildernessGoalsEnum.PursueFleeingFoes),
                        ProperName = "Pursue fleeing foes",
                        Description = "Pursue fleeing foes."
                    },
                    #endregion

                    #region 17 Assess the size of an approaching army.
                    //17 Assess the size of an approaching army.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(WildernessGoalsEnum.AssessAnApproachingArmy),
                        ProperName = "Assess an approaching army.",
                        Description = "Assess the size of an approaching army."
                    },
                    #endregion

                    #region 18 Escape the reign of a tyrant.
                    //18 Escape the reign of a tyrant.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(WildernessGoalsEnum.EscapeTheReignOfATyrant),
                        ProperName = "Escape the reign of a tyrant.",
                        Description = "Escape the reign of a tyrant."
                    },
                    #endregion

                    #region 19 Protect a wilderness site from attackers
                    //19 Protect a wilderness site from attackers
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(WildernessGoalsEnum.ProtectAWildernessSite),
                        ProperName = "Protect a wilderness site",
                        Description = "Protect a wilderness site from attackers"
                    },
                    #endregion

                    #region 20 Roll twice, again ignoring results of 20.
                    //20 Roll twice, again ignoring results of 20.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(WildernessGoalsEnum.RollTwice),
                        ProperName = "Roll twice",
                        Description = "Roll twice, again ignoring results of 20."
                    },
                    #endregion
                };
            }
        }
    }
}
