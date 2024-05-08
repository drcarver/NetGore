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
using GoDungeon.Background.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Background.Tables.Halfling
{
    public class HalflingParentsTable : RandomTable, IHalflingParentsTable
    {
        /// <summary>
        /// The parents table
        /// </summary>
        public HalflingParentsTable()
        {
            DiceSides = 100;
            Name = nameof(HalflingParentsTable);
            ProperName = "halfling parents table";
            TableType = TableTypeEnum.RaceTable;
        }

        //Table: Halfling Parents
        //d%	Result
        //01–70	Both parents living.
        //71–80	Only your father is alive.
        //81–90	Only your mother is alive.
        //91–100	Both of your parents are dead.You gain access to the Orphaned social trait
        /// <summary>
        /// Initialize the game table.  This is a separate method so 
        /// we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region "Both"
                    //01–70	Both of your parents are alive.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01,70),
                        Name = nameof(ParentsEnum.BothAlive),
                        ProperName = "Both Alive",
                        Description = "Both of your parents are alive.",
                    },
                    #endregion

                    #region "Father Only"
                    //71–80	Only your father is alive.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(71,80),
                        Name = nameof(ParentsEnum.FatherOnly),
                        ProperName = "Father Only",
                        Description = "Only your father is alive.",
                    },
                    #endregion

                    #region "Mother Only"
                    //81–90	Only your mother is alive.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(81,90),
                        Name = nameof(ParentsEnum.MotherOnly),
                        ProperName = "Mother Only",
                        Description = "Only your mother is alive.",
                    },
                    #endregion

                    #region "Both Dead"
                    //91–100 Both of your parents are dead.
                    //You gain access to the Orphaned social
                    //trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(91,100),
                        Name = nameof(ParentsEnum.BothDead),
                        ProperName = "Both Dead",
                        Description =
                            "Both of your parents are dead. " +
                            "You gain access to the Orphaned " +
                            "social trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Orphaned,
                        },
                    },
                    #endregion
                };
            }
        }
    }
}
