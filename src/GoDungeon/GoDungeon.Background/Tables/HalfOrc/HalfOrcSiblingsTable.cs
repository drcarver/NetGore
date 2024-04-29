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

namespace GoDungeon.Background.Tables.HalfOrc
{
    public class HalfOrcSiblingsTable : RandomTable, IHalfOrcSiblingsTable
    {
        /// <summary>
        /// The siblings table
        /// </summary>
        public HalfOrcSiblingsTable()
        {
            DiceSides = 100;
            Name = nameof(HalfOrcSiblingsTable);
            ProperName = "HalfOrc Siblings Table";
            TableType = TableTypeEnum.RaceTable;
        }

        //Table: Half-Orc Siblings
        //d%	Result
        //01–60	1d6+1 orc siblings.You gain access to the Kin Guardian combat trait.
        //61–70	1d4 human siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.
        //71–80	One half-orc sibling.
        //81–100	No siblings.
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
                    #region "1d6+1"
                    //01–60	1d6+1 orc siblings.You gain access to the Kin Guardian combat trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01,60),
                        Name = "1d6+1",
                        Description =
                            "1d6+1 orc siblings.You gain access " +
                            "to the Kin Guardian combat trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.KinGuardian,
                        },
                    },
                    #endregion

                    #region "1d4"
                    //61–70	1d4 human siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(61,70),
                        Name = "1d4",
                        Description =
                            "One half-elf sibling. You gain " +
                            "access to the Kin Bond magic " +
                            "trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.KinBond,
                        },
                    },
                    #endregion

                    #region "1d1"
                    //71–80	One half-orc sibling.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(71,80),
                        Name = "1d1",
                        Description =
                            "One half-orc sibling.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.KinBond,
                        },
                    },
                    #endregion

                    #region "No siblings"
                    //81–100	No siblings.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(81,100),
                        Name = "No siblings",
                        Description = "No siblings",
                    },
                    #endregion
                };
            }
        }
    }
}
