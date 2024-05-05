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

namespace GoDungeon.Background.Tables.Elf
{
    /// <summary>
    /// The homeland table
    /// </summary>
    public class ElfHomelandTable : RandomTable, IElfHomelandTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ElfHomelandTable()
        {
            DiceSides = 100;
            Name = nameof(ElfHomelandTable);
            ProperName = "Elf Homeland Table";
            TableType = TableTypeEnum.RaceTable;
        }

        //Table: Elf Homeland
        //d%	Result
        //01–60	Forest You gain access to the Log Roller regional trait.
        //61–80	Non-Elven City or Metropolis    If you’re an elf, you gain access to the Civilized social trait and the Forlorn race trait.If you’re a half-elf, you gain access to the Civilized social trait and the Failed Apprentice race trait.
        //81–95	Non-Elven Town or Village   If you’re an elf, you gain access to the Forlorn race trait. If you’re a half-elf, you gain access to the Failed Apprentice race trait.
        //96–100	Unusual Homeland.	Roll on Table: Unusual Homeland. If you’re an elf, you gain access to the Forlorn trait.If you’re a half-elf, you gain access to the Elven Reflexes race trait.
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
                    #region "Forest"
                    //01–60	Forest You gain access to the
                    //Log Roller regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01,60),
                        Name = "Forest",
                        Description =
                            "You gain access to the " +
                            "Log Roller regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                        },
                    },
                    #endregion

                    #region "Non-Elven City or Metropolis"
                    //61–80	Non-Elven City or Metropolis    
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(61,80),
                        Name = "Non-Elven City or Metropolis",
                        Description =
                            "If you’re an elf, you gain access " +
                            "to the Civilized social trait and " +
                            "the Forlorn race trait.If you’re " +
                            "a half-elf, you gain access to the " +
                            "Civilized social trait and the " +
                            "Failed Apprentice race trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Civilized
                        },

                    },
                    #endregion

                    #region "Non-Elven Town or Village"
                    //81–95	Non-Elven Town or Village
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(81,95),
                        Name = "Non-Dwarven Town or Village",
                        Description =
                            "You gain access to the Forlorn race trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Forlorn,
                        },
                    },
                    #endregion
                        
                    #region "Unusual Homeland."
                    //96–100	Unusual Homeland.
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
