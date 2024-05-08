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

namespace GoDungeon.Background.Tables.HalfElf
{
    public class HalfElfSiblingsTable : RandomTable, IHalfElfSiblingsTable
    {
        /// <summary>
        /// The siblings table
        /// </summary>
        public HalfElfSiblingsTable()
        {
            DiceSides = 100;
            Name = nameof(HalfElfSiblingsTable);
            ProperName = "HalfElf Siblings Table";
            TableType = TableTypeEnum.RaceTable;
        }

        //Table: Half-Elf Siblings
        //d%	Result
        //01–20	1d2 half-siblings(either elf or human, your choice). With two or more siblings, you gain access to the Kin Guardian combat trait.
        //21–30	One half-elf sibling.You gain access to the Kin Bond magic trait.
        //31–100	No siblings.
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
                    //01–20	1d2 half-siblings(either elf or
                    //human, your choice). With two or more
                    //siblings, you gain access to the Kin
                    //Guardian combat trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01,50),
                        Name = "1d2",
                        Description =
                            "1d2 half-siblings(either elf or " +
                            "human, your choice). With two " +
                            "or more siblings, you gain access " +
                            "to the Kin Guardian combat trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.KinGuardian,
                        },
                    },
                    #endregion

                    #region "1d1"
                    //21–30	One half-elf sibling.You gain access to the Kin Bond magic trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(21,30),
                        Name = "1d1",
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

                    #region "No siblings"
                    //31–100	No siblings.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(31,100),
                        Name = "No siblings",
                        Description = "No siblings",
                    },
                    #endregion
                };
            }
        }
    }
}
