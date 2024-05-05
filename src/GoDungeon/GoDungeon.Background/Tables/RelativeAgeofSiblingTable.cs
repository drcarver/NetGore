#region Copyright Notice and source url
//
// This content contains copyright material. The material
// format has been change to support the needs of the
// Application.  In particular the table entries and
// values have the following copyright notice.
//
// The content is from the url:
// https://www.GoDungeonpfsrd.com/basics-ability-scores/more-character-options/character-backgrounds/background-generator
//
// Pathfinder Roleplaying Game: Ultimate Campaign.
// ©2013, Paizo Publishing, LLC;
// Authors: Jesse Benner, Benjamin Bruck, Jason Bulmahn,
// Ryan Costello, Adam Daigle, Matt Goetz, Tim Hitchcock,
// James Jacobs, Ryan Macklin, Colin McComb,
// Jason Nelson, Richard Pett, Stephen Radney-MacFarland,
// Patrick Renie, Sean K Reynolds, F. Wesley Schneider,
// James L.Sutter, Russ Taylor, and Stephen Townshend.
//
#endregion

using System;
using System.Collections.ObjectModel;

using GoDungeon.Background.Enum;
using GoDungeon.Background.Interfaces;
using GoDungeon.Background.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Background.Tables
{
    /// <summary>
    /// If you have at least one sibling, roll on Table: 
    /// Relative Age of Sibling to determine the relative 
    /// age of each sibling.For each adopted sibling, 
    /// roll on Table: RaceTable to determine that 
    /// sibling’s race.
    /// </summary>
    public class RelativeAgeofSiblingTable : RandomTable, IRelativeAgeofSiblingTable
    {
        /// <summary>
        /// Relative Age of Sibling Table
        /// </summary>
        public RelativeAgeofSiblingTable()
        {
            Name = nameof(RelativeAgeofSiblingTable);
            ProperName = "Relative Age of Sibling Table";
            TableType = TableTypeEnum.BackgroundTable;
            Description = "If you have at least one sibling, roll on Table: Relative Age of Sibling to determine the relative age of each sibling. For each adopted sibling, roll on Table: Race of Adopted Sibling to determine that sibling’s race.";
            DiceSides = 100;
        }

        //Table: Relative Age of Sibling
        //d%	Result
        //01–48	Your sibling is older than you.
        //49–96	Your sibling is younger than you.
        //97–100	You and a sibling are twins (identical or fraternal, your choice). Roll on this table again. If you roll this result again, you are one of triplets; otherwise, your sibling’s relative age determines which of you emerged first.
        /// <summary>
        /// Initialize the game table.  This is a separate method 
        /// so we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region Older
                    //01–48	Your sibling is older than you.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01,48),
                        Name = nameof(RelativeAgeofSiblingEnum.Older),
                        Description = "Your sibling is older than you.",
                    },
                    #endregion

                    #region Younger
                    //49–96	Your sibling is younger than you.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(49,96),
                        Name = nameof(RelativeAgeofSiblingEnum.Younger),
                        Description = "Your sibling is younger than you.",
                    },
                    #endregion

                    #region Twins
                    //97–100 You and a sibling are twins (identical or fraternal, your choice). Roll on this table again. If you roll this result again, you are one of triplets; otherwise, your sibling’s relative age determines which of you emerged first.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(97,100),
                        Name = nameof(RelativeAgeofSiblingEnum.Twins),
                        Description = "You and a sibling are twins " +
                            "(identical or fraternal, your " +
                            "choice). Roll on this table again. " +
                            "If you roll this result again, " +
                            "you are one of triplets; otherwise, " +
                            "your sibling’s relative age " +
                            "determines which of you emerged first.",
                    },
                    #endregion
                };
            }
        }
    }
}
