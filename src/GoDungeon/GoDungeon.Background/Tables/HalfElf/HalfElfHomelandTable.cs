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
    /// <summary>
    /// The homeland table
    /// </summary>
    public class HalfElfHomelandTable : RandomTable, IHalfElfHomelandTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public HalfElfHomelandTable()
        {
            DiceSides = 100;
            Name = nameof(HalfElfHomelandTable);
            ProperName = "HalfElf Homeland Table";
            TableType = TableTypeEnum.RaceTable;
        }

        //Table: Half-Elf Homeland
        //d%	Result
        //01–25	Raised in an Elven Homeland.Roll on Table: Elf Homeland.
        //26–75	Raised in a Human Homeland.Roll on Table: Human Homeland.
        //76–95	Forest You gain access to the Log Roller regional trait.
        //96–100	Unusual Homeland.	Roll on Table: Unusual Homeland.
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
                    #region "Raised in an Elven Homeland."
                    //01–25	Raised in an Elven Homeland. Roll
                    //on Table: Elf Homeland.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01,25),
                        Name = "Raised in an Elven Homeland",
                        Description =
                            "Raised in an Elven Homeland. " +
                            "Roll on Table: Elf Homeland.",
                        //AlternateTable = Elf.HomelandTable
                    },
                    #endregion

                    #region "Raised in a Human Homeland"
                    //26–75	Raised in a Human Homeland.Roll on Table: Human Homeland.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(26,75),
                        Name = "Raised in a Human Homeland",
                        Description =
                            "Raised in a Human Homeland. Roll on Table: Human Homeland.",
                        //AlternateTable = Human.HomelandTable
                    },
                    #endregion

                    #region "Forest"
                    //76–95	Forest You gain access to the Log
                    //Roller regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(76,95),
                        Name = "Forest",
                        Description =
                            "You gain access to the Log Roller regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                        },
                    },
                    #endregion
                        
                    #region "Unusual Homeland."
                    //96–100 Unusual Homeland.	Roll on Table:
                    //Unusual Homeland.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(96,100),
                        Name = "Unusual Homeland",
                    },
                    #endregion
                };
            }
        }
    }
}
