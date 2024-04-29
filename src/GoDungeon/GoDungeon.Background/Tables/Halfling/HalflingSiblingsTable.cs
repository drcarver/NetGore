#region Copyright Notice and source url
//
// This content contains copyright material. The material
// format has been change to support the needs of the
// Application.  In particular the table entries and
// values have the following copyright notice.
//
// The content is from the url:
// https://www.d20pfsrd.com/basics-ability-scores/more-character-options/character-backgrounds/background-generator
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

using GoDungeon.Background.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Background.Tables.Halfling
{
    public class HalflingSiblingsTable : RandomTable, IHalflingSiblingsTable
    {
        /// <summary>
        /// The siblings table
        /// </summary>
        public HalflingSiblingsTable()
        {
            DiceSides = 100;
            Name = nameof(HalflingSiblingsTable);
            ProperName = "Halfling Siblings Table";
            TableType = TableTypeEnum.RaceTable;
        }

        //Table: Halfling Siblings
        //d%	Result
        //01–30	1d2 siblings.With two siblings, you gain access to the Kin Guardian combat trait.
        //31–90	1d4+1 siblings.You gain access to the Kin Guardian combat trait.
        //91–100	No siblings.
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
                    #region "1d2"
                    //01–30	1d2 siblings.With two siblings,
                    //you gain access to the Kin Guardian
                    //combat trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01, 30),
                        Name = "1d2",
                        Description = "1d2 siblings. With two siblings, you gain access to the Kin Guardian combat trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.KinGuardian,
                        },
                    },
                    #endregion

                    #region "1d4+1"
                    //1d4+1 siblings. You gain access to the
                    //Kin Guardian combat trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(31, 90),
                        Name = "1d4+1",
                        Description =
                            "1d4+1 siblings. You gain access to the Kin Guardian combat trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.KinGuardian,
                        },
                    },
                    #endregion

                    #region "No siblings"
                    //91–100	No siblings.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(91, 100),
                        Name = "No siblings",
                        Description = "No siblings",
                    },
                    #endregion
                };
            }
        }
    }
}
