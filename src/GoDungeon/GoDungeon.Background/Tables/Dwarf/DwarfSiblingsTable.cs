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

using GoDungeon.Background.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Background.Tables.Dwarf
{
    public class DwarfSiblingsTable : RandomTable, IDwarfSiblingsTable
    {
        /// <summary>
        /// The siblings table
        /// </summary>
        public DwarfSiblingsTable()
        {
            DiceSides = 100;
            Name = nameof(DwarfSiblingsTable);
            ProperName = "Dwarf Siblings Table";
            TableType = TableTypeEnum.RaceTable;
        }

        //Table: Dwarf Siblings
        //d%	Result
        //01–80	1d4 biological siblings.With two or more siblings, you gain access to the Kin Guardian combat trait.
        //81–90	1d4+1 biological siblings. You gain access to the Kin Guardian combat trait.
        //91–95	1d3–1 biological siblings and 1d3–1 adopted siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
        //96–100	No siblings    
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
                    #region "1d4"
                    //01–80	1d4 biological siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01,80),
                        Name = "1d4",
                        Description =
                            "1d4 biological siblings. With two " +
                            "or more siblings, you gain access " +
                            "to the Kin Guardian combat trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.KinGuardian,
                        },
                    },
                    #endregion

                    #region "1d4+1"
                    //81–90	1d4+1 biological siblings. You gain access to the Kin Guardian combat trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(81,90),
                        Name = "1d4+1",
                        Description =
                            "1d4+1 biological siblings. You gain access to " +
                            "the Kin Guardian combat trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.KinGuardian,
                        },
                    },
                    #endregion

                    #region "1d3–1 and 1d3–1"
                    //91–95	1d3–1 biological siblings and 1d3–1 adopted siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(91,95),
                        Name = "1d3",
                        Description = "1d3–1 Biological siblings and " +
                            "1d3–1 adopted siblings. With two or " +
                            "more siblings, you gain access to the " +
                            "Kin Guardian combat trait. Roll on Table: " +
                            "Race Table to determine the " +
                            "race of any adopted siblings.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.KinGuardian,
                        },
                    },
                    #endregion

                    #region "No siblings"
                    //96–100 No siblings    
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(96,100),
                        Name = "No siblings",
                        Description = "No siblings",
                    },
                    #endregion
                };
            }
        }
    }
}
